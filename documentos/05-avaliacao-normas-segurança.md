# 5\. AVALIAÇÃO DAS NORMAS DE SEGURANÇA DA EMPRESA (Etapa 2)

5.1 **Normas de segurança identificadas na empresa**

**LGPD (Lei 13.709/18):** Proteção obrigatória de dados pessoais e financeiros de alunos e funcionários através de criptografia e controle de acesso.

**Lei Carolina Dieckmann (Lei 12.737/12):** Pune criminalmente a invasão de sistemas, redes e servidores da instituição.

**Marco Civil da Internet (Lei 12.965/14):** Obriga a guarda segura dos registros de acesso (logs) dos usuários por 6 meses.

**Lei de Software (Lei 9.609/98):** Exige o uso de programas licenciados e combate o plágio de códigos.

**MP 2.200-2/01:** Valida juridicamente a assinatura eletrônica dos contratos de matrícula.

**Lei de Propriedade Industrial (Lei 9.279/96):** Protege patentes e segredos de projetos feitos com indústrias parceiras.
 
**Lei de Acessibilidade (Lei 13.146/15):** Obriga que sites, sistemas e softwares de simulação aceitem leitores de tela e comandos por teclado.

**Lei das Mensalidades (Lei 9.870/99):** Proíbe bloqueios pedagógicos ou suspensão de provas por atraso no pagamento.

**5.2 Detalhamento do mapeamento de riscos de segurança da informação**

**Segurança Física da Rede**
​
A segurança física visa proteger tanto os equipamentos institucionais quanto as máquinas Windows onde os arquivos do projeto são desenvolvidos e executados:
​
**Acesso às Estações de Desenvolvimento e Servidores:** Restrição de acesso físico aos computadores onde o protótipo HTML, o script em C# e os arquivos de inventário são manipulados, utilizando bloqueio de tela por senha e controle de acesso aos laboratórios/salas.

**Integridade dos Equipamentos de Rede:** Proteção dos roteadores e switches que conectam o sistema de rematrícula à rede local/nuvem para impedir capturas de tráfego (sniffing) por conexões físicas não autorizadas.
​
**Continuidade de Energia:** Uso de no-breaks nos servidores do sistema para evitar perda de dados de solicitações de rematrícula em andamento caso ocorra uma queda repentina de energia.

**Normas Técnicas Aplicadas**
​
* LGPD (Lei Geral de Proteção de Dados - Lei nº 13.709/2018): Proteção rigorosa dos dados pessoais e acadêmicos dos alunos solicitantes de rematrícula (CPF, histórico, dados financeiros/matrícula).

* ABNT NBR ISO/IEC 27001 (Gestão de Ativos e Controle de Acesso): Diretrizes aplicadas à organização do inventário de máquinas (gerado pelo script em .dat) e à restrição de execução de scripts no PowerShell apenas a usuários autorizados.

**Plano de Contingência**

O escopo prático consiste em um protótipo estático em HTML e um script local em C# executado via PowerShell, o plano de contingência foca nos cuidados práticos com essas ferramentas:

* **Tratamento de Exceções no Script (C#):** Validação das entradas do usuário no menu interativo (1. Hardware, 2. Software, 3. Hardware e Software) para evitar que digitações inválidas encerrem o programa abruptamente (crash) antes de gravar o arquivo .dat.

* **Preservação e Cópia dos Arquivos de Inventário:** Como o armazenamento ocorre localmente em arquivo .dat, recomenda-se a realização de cópias periódicas desses arquivos para um diretório seguro ou mídia externa, evitando perda por falha no disco rígido da máquina.

**TABELA DE ANÁLISEDE SEGURANÇA DO SISTEMA:**

| Tipo de controle | Descrição | Responsável |
| --- | --- | --- |
| **Controles de Software** | Tratamento de erros de digitação no menu do script em C# (PowerShell) e estruturação limpa do código-fonte HTML/C#. | Equipe de Desenvolvimento |
| **Controles de Hardware** | Monitoramento de uso de CPU e memória do servidor para suportar picos de acessos simultâneos no período de rematrícula. | Infraestrutura / Suporte |
| **Processos Operacionais** | Controle de acesso por perfil (RBAC): aluno altera apenas seu pedido; atendente valida; administrador gerencia o sistema. | Administrador do Sistema |
| **Controles de Conscientização** |Orientação aos operadores e alunos sobre boas práticas contra phishing e não compartilhamento de arquivos internos em canais públicos. | Gestão do Projeto |
| **Controles de Backup e Auditoria** | Registro em log de todas as operações de alteração de status da rematrícula e execução de backup diário do banco de dados. | Analista de Banco de Dados |

**Análise de risco:**

| Tipo de exposição | Probabilidade de ocorrência | Estimativa de prejuízo (mensal/anual) |
| --- | --- | --- |
| **Falhas de Software / Injeção de Dados** | Média | **Alta:** Alteração indevida de dados de alunos, perda de pedidos de rematrícula e retrabalho manual da equipe. |
| **Sobrecarga de Hardware / Servidor** | Média/Alta | **Média:** Queda do sistema, lentidão no atendimento aos alunos e descumprimento dos prazos de rematrícula. |
| **Falhas nos Processos Operacionais** | Baixa | **Alta:** Aplicação de multas da LGPD e danos à reputação da instituição por vazamento de dados. |
| **Interrupção de Conexão ou Banco de Dados** | Baixa | **Alta:** Impossibilidade de concluir novos pedidos e perda de dados não salvos da sessão do aluno em caso de falha de conexão. |







