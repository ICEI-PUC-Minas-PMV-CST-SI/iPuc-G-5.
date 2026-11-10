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


| Tipo de exposição | Probabilidade de ocorrência | Estimativa de prejuízo (mensal/anual) |
| :--- | :--- | :--- |
| **Softwares (Injeção de SQL / Falha no CRUD de Rematrícula)** | Média | **Alta:** Alteração indevida de dados de alunos, perda de pedidos de rematrícula e retrabalho manual da equipe. |
| **Hardwares (Sobrecarga do Servidor em Horário de Pico)** | Média/Alta | **Média:** Queda do sistema, lentidão no atendimento aos alunos e descumprimento dos prazos de rematrícula. |
| **Processos de Operação (Vazamento de dados de alunos - LGPD)** | Baixa | **Alta:** Aplicação de multas da LGPD e danos à reputação da instituição. |
| **Indisponibilidade do Banco de Dados / Falha de Conexão** | Baixa | **Alta:** Impossibilidade de concluir novos pedidos e perda de dados não salvos da sessão do aluno. |


Exemplo:

| Tipo de controle | Descrição | Responsável |
| --- | --- | --- |
| \*\* relatar softwares |     |     |
| \*\* relatar hardwares |     |     |
| \*\* relatar processos de operação de computador |     |     |
| \*\* outros relatos |     |     |
| \*\* outros relatos |      |     |

Análise de risco:

| Tipo de exposição | Probabilidade de ocorrência | Estimativa de prejuízo (mensa/anual) |
| --- | --- | --- |
| \*\* relatar softwares |     |     |
| \*\* relatar hardwares |     |     |
| \*\* relatar processos de operação de computador |     |     |
| \*\* outros relatos |     |     |
