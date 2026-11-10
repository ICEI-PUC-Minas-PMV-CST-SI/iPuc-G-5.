# Crud-g5 - Inventario de computadores em C# (PowerShell)

Trabalho da faculdade (Fundamentos de Sistemas, Etapa 3, item 3): sistema de inventario de computadores em **C#**, para **Windows**, executavel no **PowerShell**.

## Requisitos do trabalho x como foram atendidos

| Requisito | Como foi atendido |
|---|---|
| Script em C# | Codigo-fonte unico: `crud.cs` |
| Menu com 3 opcoes de inventario | **1** Hardware, **2** Software, **3** Hardware e Software |
| Somente Windows | Usa o PowerShell 5.1 e o compilador do .NET Framework 4, presentes no Windows 10/11. O script recusa rodar em outro sistema |
| Inventario salvo em arquivo texto `.dat` | `hardware.dat`, `software.dat`, `hardware_software.dat`, com cabecalho na primeira linha |
| Rodar no PowerShell | `Iniciar-crud.ps1` compila o C# em memoria (`Add-Type`) e executa. Tambem pode rodar o `crud.exe` |
| Sistema CRUD | Em cada categoria: **Cadastrar** (Create), **Consultar** (Read), **Buscar**, **Editar** (Update), **Remover** (Delete) |

## Como executar

Abra o PowerShell dentro da pasta `Crud-g5`.

### Opcao 1 - pelo script (sem compilar)

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File .\Iniciar-crud.ps1
```

Nada precisa ser instalado: o proprio PowerShell compila o codigo.

### Opcao 2 - pelo executavel

```powershell
.\crud.exe
```

Para gerar o `crud.exe` novamente a partir do codigo-fonte:

```powershell
C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe /out:crud.exe crud.cs
```

(Em Windows 32 bits, troque `Framework64` por `Framework`.)

## Estrutura dos arquivos `.dat`

Criados na pasta do projeto no primeiro cadastro de cada categoria.

| Arquivo | Categoria | Campos |
|---|---|---|
| `hardware.dat` | Hardware | Equipamento; Fabricante; Modelo; Quantidade |
| `software.dat` | Software | Software; Fabricante; Versao; Licencas |
| `hardware_software.dat` | Hardware e Software | Computador; Hardware; Softwares instalados; Quantidade |

Primeira linha = cabecalho com o nome dos campos; demais linhas = um item por linha, campos separados por `;`, UTF-8. Exemplo (`software.dat`):

```
Software;Fabricante;Versao;Licencas
Microsoft Office 2021;Microsoft;2021;10
Adobe Photoshop;Adobe;2024;3
```

O cabecalho e regravado a cada salvamento, entao continua la mesmo se todos os itens forem removidos.

## Arquivos da pasta

| Arquivo | Descricao |
|---|---|
| `crud.cs` | Codigo-fonte com os menus e as operacoes CRUD |
| `Iniciar-crud.ps1` | Script PowerShell que compila e executa o sistema |
| `crud.exe` | Versao ja compilada (gerada com o comando da Opcao 2) |
| `README.md` | Este documento |

> O codigo-fonte usa so caracteres ASCII e recursos do C# 5, para compilar no PowerShell 5.1 de qualquer Windows.

## Equipe (Grupo 5)

- Eduarda de Araujo Brito
- Fabio Roberto Santos da Silva
- Jefferson Oliveira
- Julio Cesar de Lima Salles
- Kayane Caroline da Silva Goncalves
- Leticia Dayane Santos Silva
- Kaua Vianna Nonaka
