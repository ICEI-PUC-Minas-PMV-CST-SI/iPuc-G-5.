using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class InventarioSistema
{
    private const string NOME_SISTEMA = "INVENTARIO";
    private const ConsoleColor COR_BANNER = ConsoleColor.Cyan;
    private const ConsoleColor COR_TITULO = ConsoleColor.Yellow;
    private const ConsoleColor COR_OPCAO = ConsoleColor.White;
    private const ConsoleColor COR_NUMERO = ConsoleColor.Green;
    private const ConsoleColor COR_SUCESSO = ConsoleColor.Green;
    private const ConsoleColor COR_ERRO = ConsoleColor.Red;
    private const ConsoleColor COR_SUAVE = ConsoleColor.DarkGray;

    public static string PastaDados = ".";
    private static bool FimDaEntrada = false;

    private class Categoria
    {
        public string Titulo;
        public string Arquivo;
        public string[] Campos;
        public Categoria(string titulo, string arquivo, string[] campos)
        {
            Titulo = titulo; Arquivo = arquivo; Campos = campos;
        }
    }

    private static readonly Categoria HARDWARE = new Categoria("Hardware", "hardware.dat",
        new string[] { "Equipamento", "Fabricante", "Modelo", "Quantidade" });

    private static readonly Categoria SOFTWARE = new Categoria("Software", "software.dat",
        new string[] { "Software", "Fabricante", "Versao", "Licencas" });

    private static readonly Categoria AMBOS = new Categoria("Hardware e Software", "hardware_software.dat",
        new string[] { "Computador", "Hardware", "Softwares instalados", "Quantidade" });

    public static void Main(string[] args)
    {
        PastaDados = AppDomain.CurrentDomain.BaseDirectory;
        Executar();
    }

    public static void Executar()
    {
        try { Console.OutputEncoding = Encoding.UTF8; } catch { }

        while (true)
        {
            Cabecalho("MENU PRINCIPAL");
            Opcao("1", "Hardware");
            Opcao("2", "Software");
            Opcao("3", "Hardware e Software");
            Opcao("0", "Sair");
            string op = Perguntar("Escolha");
            if (FimDaEntrada) break;

            if (op == "1") MenuCrud(HARDWARE);
            else if (op == "2") MenuCrud(SOFTWARE);
            else if (op == "3") MenuCrud(AMBOS);
            else if (op == "0") { Aviso("Ate logo!", COR_TITULO); break; }
            else { Aviso("Opcao invalida.", COR_ERRO); Pausa(); }
        }
    }

    private static void MenuCrud(Categoria cat)
    {
        while (true)
        {
            Cabecalho("INVENTARIO DE " + cat.Titulo.ToUpper());
            Console.WriteLine("  Arquivo: " + cat.Arquivo + "   Itens: " + Carregar(cat).Count);
            Console.WriteLine();
            Opcao("1", "Cadastrar  (Create)");
            Opcao("2", "Consultar  (Read)");
            Opcao("3", "Buscar por texto");
            Opcao("4", "Editar     (Update)");
            Opcao("5", "Remover    (Delete)");
            Opcao("0", "Voltar");
            string op = Perguntar("Escolha");
            if (FimDaEntrada) return;

            if (op == "0") return;
            else if (op == "1") Cadastrar(cat);
            else if (op == "2") Consultar(cat);
            else if (op == "3") Buscar(cat);
            else if (op == "4") Editar(cat);
            else if (op == "5") Remover(cat);
            else Aviso("Opcao invalida.", COR_ERRO);
            Pausa();
        }
    }

    private static void Cadastrar(Categoria cat)
    {
        Titulo("Novo item");
        string[] valores = PedirCampos(cat);
        if (FimDaEntrada) return;

        List<string[]> itens = Carregar(cat);
        itens.Add(valores);
        Gravar(cat, itens, "Item cadastrado.");
    }

    private static void Consultar(Categoria cat)
    {
        Titulo("Itens cadastrados");
        List<string[]> itens = Carregar(cat);
        if (itens.Count == 0) { Aviso("Nenhum item cadastrado.", COR_SUAVE); return; }
        Tabela(cat, itens, null);
    }

    private static void Buscar(Categoria cat)
    {
        Titulo("Buscar");
        string termo = Perguntar("Texto a procurar");
        if (FimDaEntrada || termo.Length == 0) return;

        List<string[]> itens = Carregar(cat);
        List<string[]> achados = new List<string[]>();
        List<int> posicoes = new List<int>();
        for (int i = 0; i < itens.Count; i++)
        {
            if (string.Join(" ", itens[i]).ToLower().Contains(termo.ToLower()))
            {
                achados.Add(itens[i]);
                posicoes.Add(i + 1);
            }
        }

        if (achados.Count == 0) { Aviso("Nada encontrado.", COR_SUAVE); return; }
        Tabela(cat, achados, posicoes);
    }

    private static void Editar(Categoria cat)
    {
        Titulo("Editar item");
        List<string[]> itens = Carregar(cat);
        if (itens.Count == 0) { Aviso("Nenhum item cadastrado.", COR_SUAVE); return; }

        Tabela(cat, itens, null);
        int n = PedirNumero(itens.Count);
        if (n == 0) { Aviso("Cancelado.", COR_SUAVE); return; }

        Console.WriteLine("  Novos dados do item " + n + ":");
        string[] valores = PedirCampos(cat);
        if (FimDaEntrada) return;

        itens[n - 1] = valores;
        Gravar(cat, itens, "Item atualizado.");
    }

    private static void Remover(Categoria cat)
    {
        Titulo("Remover item");
        List<string[]> itens = Carregar(cat);
        if (itens.Count == 0) { Aviso("Nenhum item cadastrado.", COR_SUAVE); return; }

        Tabela(cat, itens, null);
        int n = PedirNumero(itens.Count);
        if (n == 0) { Aviso("Cancelado.", COR_SUAVE); return; }

        string resp = Perguntar("Remover o item " + n + "? (S/N)");
        if (resp.ToUpper() != "S") { Aviso("Cancelado.", COR_SUAVE); return; }

        itens.RemoveAt(n - 1);
        Gravar(cat, itens, "Item removido.");
    }

    private static string[] PedirCampos(Categoria cat)
    {
        string[] valores = new string[cat.Campos.Length];
        for (int i = 0; i < cat.Campos.Length; i++)
        {
            bool numerico = (i == cat.Campos.Length - 1);
            while (true)
            {
                string v = Perguntar(cat.Campos[i]).Replace(";", ",");
                if (FimDaEntrada) return valores;
                if (v.Length == 0) { Aviso("Campo obrigatorio.", COR_ERRO); continue; }
                if (numerico)
                {
                    int q;
                    if (!int.TryParse(v, out q) || q <= 0)
                    {
                        Aviso("Digite um numero inteiro maior que zero.", COR_ERRO);
                        continue;
                    }
                }
                valores[i] = v;
                break;
            }
        }
        return valores;
    }

    private static int PedirNumero(int total)
    {
        while (true)
        {
            string t = Perguntar("Numero do item (0 cancela)");
            if (FimDaEntrada) return 0;
            int n;
            if (int.TryParse(t, out n) && n >= 0 && n <= total) return n;
            Aviso("Digite um numero de 0 a " + total + ".", COR_ERRO);
        }
    }

    private static string Perguntar(string rotulo)
    {
        Escrever("  " + rotulo + " > ", COR_NUMERO, false);
        string linha = Console.ReadLine();
        if (linha == null) { FimDaEntrada = true; return ""; }
        return linha.Trim();
    }

    private static string Caminho(Categoria cat)
    {
        return Path.Combine(PastaDados, cat.Arquivo);
    }

    private static List<string[]> Carregar(Categoria cat)
    {
        List<string[]> itens = new List<string[]>();
        string caminho = Caminho(cat);
        if (!File.Exists(caminho)) return itens;

        string cabecalho = string.Join(";", cat.Campos);
        string[] linhas = File.ReadAllLines(caminho, Encoding.UTF8);
        for (int i = 0; i < linhas.Length; i++)
        {
            if (linhas[i].Trim().Length == 0) continue;
            if (i == 0 && linhas[i] == cabecalho) continue;
            itens.Add(linhas[i].Split(';'));
        }
        return itens;
    }

    private static void Gravar(Categoria cat, List<string[]> itens, string mensagem)
    {
        try
        {
            List<string> linhas = new List<string>();
            linhas.Add(string.Join(";", cat.Campos));
            foreach (string[] item in itens) linhas.Add(string.Join(";", item));
            File.WriteAllLines(Caminho(cat), linhas.ToArray(), Encoding.UTF8);
            Aviso(mensagem, COR_SUCESSO);
        }
        catch (IOException e)
        {
            Aviso("Erro ao salvar: " + e.Message, COR_ERRO);
        }
    }

    private static void Pausa()
    {
        if (FimDaEntrada) return;
        Console.WriteLine();
        Escrever("  Pressione Enter para continuar...", COR_SUAVE, false);
        if (Console.ReadLine() == null) FimDaEntrada = true;
    }

    private static void Cabecalho(string secao)
    {
        try { Console.Clear(); } catch { }
        Console.WriteLine();
        Escrever("  " + NOME_SISTEMA, COR_BANNER, false);
        Escrever("  /  " + secao, COR_TITULO, true);
        Escrever("  " + new string('-', 44), COR_SUAVE, true);
    }

    private static void Titulo(string texto)
    {
        Console.WriteLine();
        Escrever("  >> " + texto.ToUpper(), COR_TITULO, true);
    }

    private static void Opcao(string numero, string texto)
    {
        Escrever("   [" + numero + "] ", COR_NUMERO, false);
        Escrever(texto, COR_OPCAO, true);
    }

    private static void Aviso(string texto, ConsoleColor cor)
    {
        Escrever("  * " + texto, cor, true);
    }

    private static void Tabela(Categoria cat, List<string[]> itens, List<int> numeros)
    {
        int cols = cat.Campos.Length;
        int[] larg = new int[cols];
        for (int c = 0; c < cols; c++)
        {
            larg[c] = cat.Campos[c].Length;
            foreach (string[] item in itens)
                if (c < item.Length && item[c].Length > larg[c]) larg[c] = item[c].Length;
            if (larg[c] > 28) larg[c] = 28;
        }

        Console.WriteLine();
        StringBuilder cab = new StringBuilder("   #  ");
        for (int c = 0; c < cols; c++) cab.Append(Ajustar(cat.Campos[c], larg[c])).Append("  ");
        Escrever(cab.ToString(), COR_BANNER, true);

        int total = 5;
        for (int c = 0; c < cols; c++) total += larg[c] + 2;
        Escrever("  " + new string('-', total), COR_SUAVE, true);

        for (int i = 0; i < itens.Count; i++)
        {
            int numero = (numeros == null) ? i + 1 : numeros[i];
            Escrever("  " + numero.ToString().PadLeft(2) + "  ", COR_NUMERO, false);
            StringBuilder linha = new StringBuilder();
            for (int c = 0; c < cols; c++)
            {
                string v = c < itens[i].Length ? itens[i][c] : "";
                linha.Append(Ajustar(v, larg[c])).Append("  ");
            }
            Escrever(linha.ToString(), COR_OPCAO, true);
        }
        Escrever("  Total: " + itens.Count, COR_SUAVE, true);
    }

    private static string Ajustar(string texto, int largura)
    {
        if (texto.Length > largura) return texto.Substring(0, largura - 2) + "..";
        return texto.PadRight(largura);
    }

    private static void Escrever(string texto, ConsoleColor cor, bool novaLinha)
    {
        ConsoleColor anterior = Console.ForegroundColor;
        try { Console.ForegroundColor = cor; } catch { }
        if (novaLinha) Console.WriteLine(texto); else Console.Write(texto);
        try { Console.ForegroundColor = anterior; } catch { }
    }
}
