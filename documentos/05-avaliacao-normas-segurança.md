# 5\. AVALIAÇÃO DAS NORMAS DE SEGURANÇA DA EMPRESA (Etapa 2)

5.1 **Normas de segurança identificadas na empresa**

LGPD (Lei 13.709/18): Proteção obrigatória de dados pessoais e financeiros de alunos e funcionários através de criptografia e controle de acesso.
Lei Carolina Dieckmann (Lei 12.737/12): Pune criminalmente a invasão de sistemas, redes e servidores da instituição.
Marco Civil da Internet (Lei 12.965/14): Obriga a guarda segura dos registros de acesso (logs) dos usuários por 6 meses.
Lei de Software (Lei 9.609/98): Exige o uso de programas licenciados e combate o plágio de códigos.
MP 2.200-2/01: Valida juridicamente a assinatura eletrônica dos contratos de matrícula.
Lei de Propriedade Industrial (Lei 9.279/96): Protege patentes e segredos de projetos feitos com indústrias parceiras.
 Lei de Acessibilidade (Lei 13.146/15): Obriga que sites, sistemas e softwares de simulação aceitem leitores de tela e comandos por teclado.
 Lei das Mensalidades (Lei 9.870/99): Proíbe bloqueios pedagógicos ou suspensão de provas por atraso no pagamento.

5.2 **Detalhamento do mapeamento de riscos de segurança da informação**
5.2  Segurança Física da Rede
​A segurança física do sistema de rematrícula visa garantir a integridade dos dados dos alunos e a disponibilidade da aplicação durante os períodos de pico de acesso (início de semestre):
​Acesso às Estações de Desenvolvimento e Servidores: Restrição de acesso físico aos equipamentos onde o código-fonte (projeto C#) e o banco de dados da rematrícula estão hospedados, utilizando senhas de bloqueio de tela e controle de entrada nos ambientes.
​Integridade dos Equipamentos de Rede: Proteção dos roteadores e switches que conectam o sistema de rematrícula à rede local/nuvem para impedir capturas de tráfego (sniffing) por conexões físicas não autorizadas.
​Continuidad de Energia: Uso de no-breaks nos servidores do sistema para evitar perda de dados de solicitações de rematrícula em andamento caso ocorra uma queda repentina de energia.


5.2 **Detalhamento do mapeamento de riscos de segurança da informação**

**Segurança Física da Rede**

​A segurança física do sistema de rematrícula visa garantir a integridade dos dados dos alunos e a disponibilidade da aplicação durante os períodos de pico de acesso (início de semestre):
​Acesso às Estações de Desenvolvimento e Servidores: Restrição de acesso físico aos equipamentos onde o código-fonte (projeto C#) e o banco de dados da rematrícula estão hospedados, utilizando senhas de bloqueio de tela e controle de entrada nos ambientes.
​Integridade dos Equipamentos de Rede: Proteção dos roteadores e switches que conectam o sistema de rematrícula à rede local/nuvem para impedir capturas de tráfego (sniffing) por conexões físicas não autorizadas.
​Continuidad de Energia: Uso de no-breaks nos servidores do sistema para evitar perda de dados de solicitações de rematrícula em andamento caso ocorra uma queda repentina de energia.
​Análise de Riscos, Plano de Contingência e Normas Técnicas
​1. Normas Técnicas Aplicadas
​LGPD (Lei Geral de Proteção de Dados - Lei nº 13.709/2018): Proteção rigorosa dos dados pessoais e acadêmicos dos alunos solicitantes de rematrícula (CPF, histórico, dados financeiros/matrícula).
​OWASP Top 10: Aplicação de diretrizes contra vulnerabilidades web (como Injeção de SQL nas buscas de alunos e XSS nos formulários de cadastro).
​ABNT NBR ISO/IEC 27001: Diretrizes para controle de acesso às operações de CRUD (Criar, Ler, Atualizar, Deletar) do sistema.
​2. Plano de Contingência e Continuidade
​Backup das Rematrículas: Rotinas automatizadas de cópia de segurança do banco de dados (solicitações pendentes, validadas e confirmadas) durante todo o período de rematrícula.
​Plano de Redundância (Failover): Manutenção de ambiente secundário para que, caso o serviço C# ou a base de dados principal apresente falha, as solicitações dos alunos não sejam perdidas.
​Tratamento de Exceções no Código: Validações de entrada de dados via C# para prevenir que erros de digitação do usuário derrubem a aplicação (crashes de execução).


| Tipo de controle | Descrição | Responsável |
| --- | --- | --- |
| ** softwares relacionados ** | Implementação de validações de entrada no backend (C#), firewall de aplicação e criptografia de senhas de acesso. | Equipe de Desenvolvimento |
| ** hardwares relacionados ** | Monitoramento de uso de CPU e memória do servidor para suportar picos de acessos simultâneos no período de rematrícula. | Infraestrutura / Suporte |
| ** relatar processos de operação de computador ** | Controle de acesso por perfil (RBAC): aluno altera apenas seu pedido; atendente valida; administrador gerencia o sistema. | Administrador do Sistema |
| ** outros relatos ** | Orientação à equipe de atendimento para identificação de chamados falsos ou tentativas de engenharia social. | Gestão do Projeto |
| ** outros relatos ** | Registro em log de todas as operações de alteração de status da rematrícula e execução de backup diário do banco de dados. | Analista de Banco de Dados |

Análise de risco:

| Tipo de exposição | Probabilidade de ocorrência | Estimativa de prejuízo (mensal/anual) |
| --- | --- | --- |
| ** softwares relacionados ** | Média | **Alta:** Alteração indevida de dados de alunos, perda de pedidos de rematrícula e retrabalho manual da equipe. |
| ** hardwares relacionados ** | Média/Alta | **Média:** Queda do sistema, lentidão no atendimento aos alunos e descumprimento dos prazos de rematrícula. |
| ** relatar processos de operação de computador ** | Baixa | **Alta:** Aplicação de multas da LGPD e danos à reputação da instituição por vazamento de dados. |
| ** outros relatos ** | Baixa | **Alta:** Impossibilidade de concluir novos pedidos e perda de dados não salvos da sessão do aluno em caso de falha de conexão. |





