
## Objetivos

**2.1 Objetivo Geral**

A visão dos processos de negócios organizacionais voltada para o core de rematrícula integra diretamente a segurança da informação ao ciclo operacional da instituição, conectando o fluxo estratégico às ferramentas desenvolvidas: o protótipo em HTML e o gerenciamento de dados via CRUD em C#.
.

**2.2 Objetivos Específicos**

● O contexto do negócio do core de rematrícula é o ambiente operacional da instituição de ensino focado em renovar a matrícula do aluno com eficiência e proteção de dados, o fluxo de rematrícula funciona na prática, identificando as necessidades das partes envolvidas, os riscos operacionais e de segurança, e a função de cada tecnologia no processo.

●  As principais normas de segurança da informação (como ISO/IEC 27001/27002 e NIST CSF) organizam suas regras em 4 categorias essenciais.
​No sistema de rematrícula, esses itens são aplicados assim:

**​1. Controles Tecnológicos (Proteção do Software)**

​Desenvolvimento Seguro: Escrever o código C# (CRUD) de forma a bloquear invasões (ex: validar entradas contra SQL Injection).
​Criptografia: Proteger a comunicação no site HTML (usando HTTPS) e codificar dados sensíveis de alunos no banco de dados.
​Controle de Acesso: Garantir que o aluno só veja a própria rematrícula, enquanto a secretaria gerencia as turmas.

**2. Controles Organizacionais (Regras e Processos)**

​Políticas de Segurança: Regras institucionais sobre quem pode visualizar, alterar ou excluir registros acadêmicos e financeiros.
​Gestão de Ativos: Mapear e proteger o código-fonte, servidores e bases de dados do sistema.

**​3. Controles Operacionais (Monitoramento e Resposta)**

​Auditoria de Logs: Registrar histórico de quem executou cada ação de Criar, Atualizar ou Deletar no CRUD em C#.
​Backups e Recuperação: Garantir cópias de segurança atualizadas para o sistema não parar durante o período de rematrícula.

**​4. Controles Pessoas (Treinamento)**

​Conscientização: Treinar a equipe que opera o sistema para não cair em golpes de captura de senhas (phishing).



**1.Modelo de Topologia:**

A arquitetura do nosso sistema segue um modelo estruturado em camadas para garantir organização, facilidade de manutenção e segurança das informações acadêmicas:
Camada de Apresentação (Front-end): É a interface web desenvolvida em HTML onde o aluno acessa o sistema, visualiza as disciplinas disponíveis e preenche os dados de renovação de matrícula.
Camada de Negócio e Lógica (Back-end): Desenvolvida em C#, é o "motor" do sistema. Ela processa as requisições enviadas pelo aluno, aplica as regras de negócio da instituição e gerencia as operações do CRUD (Create, Read, Update, Delete — Criar, Ler, Atualizar e Excluir).
Camada de Dados (Banco de Dados): Onde ficam armazenados de forma centralizada e segura os registros dos alunos, históricos e dados financeiros, protegidos por controles de acesso.

**2.Como os dados trafegam**

No projeto, o mapeamento desse processo funciona de forma integrada:
1. Acesso do Aluno: O estudante entra na página em HTML, insere suas credenciais de forma segura (com autenticação) e solicita a rematrícula.
2. Tratamento no Back-end: O sistema em C# recebe essa solicitação, valida se o aluno possui pendências e processa a alteração no banco de dados através das funções do CRUD.
3. Resposta Visual: O sistema retorna uma confirmação imediata na interface web para o usuário, garantindo que o ciclo de renovação foi concluído com sucesso.


**3.O Instituto Politécnico (IPUC) da PUC Minas —, a cultura organizacional :**

E a dimensão religiosa (humanista e católica) exercem um impacto direto nas operações, na missão e nos sistemas de tecnologia da instituição.  
Para o trabalho de faculdade/documentação do projeto, você pode apresentar a avaliação do impacto cultural e religioso dividida nos seguintes pontos estratégicos:
Missão Institucional e Valores Cristãos
Formação Humanista: A missão do IPUC é formar profissionais e cidadãos éticos, aliando a excelência técnica em Engenharia e Tecnologia à geração de conhecimento pautada nos valores cristãos.  
Impacto no Dia a Dia: A cultura católica humanista se reflete no compromisso com a solidariedade, a responsabilidade social e a sustentabilidade, orientando as decisões operacionais e o respeito à dignidade humana.  

**4.Impacto nos Processos de Atendimento e Negócio:**

Tratamento Humanizado ao Aluno: A cultura institucional exige que processos administrativos e financeiros (como a rematrícula) priorizem o respeito ao estudante. Em situações de pendência ou inadimplência, a política institucional busca a negociação amigável em vez de punições pedagógicas.  
Inclusão e Diversidade: A responsabilidade social da instituição orienta a inclusão de diversos perfis de estudantes (como beneficiários do Prouni) e exige uma atuação focada em acolhimento e acessibilidade.  

**5.Impacto na Tecnologia e na Segurança da Informação:**

A identidade cultural e ética da universidade se traduz em diretrizes práticas de TI:
Privacidade e Proteção de Dados: A ética cristã de respeito ao indivíduo alinha-se diretamente com o cumprimento da LGPD, garantindo que os dados pessoais de alunos e professores sejam coletados com transparência e protegidos contra vazamentos.  
Desenvolvimento Ético de Software: No desenvolvimento do nosso sistema de rematrícula (HTML/C#), a cultura de integridade exige código seguro (para evitar falhas ou invasões) e combate rigoroso ao plágio e uso ilícito de dados.  
Acessibilidade Digital: A visão de inclusão social obriga o setor de TI a criar interfaces (como no portal de matrícula e no AVA) compatíveis com tecnologias assistivas para pessoas com deficiência.  

​"O presente projeto de intervenção propõe a reestruturação organizacional do processo de rematrícula do IPUC Engenharia através da adoção de metodologias ágeis de gerenciamento de projetos. Atualmente, o fluxo operacional enfrenta gargalos na validação documental e na garantia da segurança dos dados dos discentes. A intervenção organiza a equipe em papéis bem definidos (PO, Scrum Master e Time Dev/Segurança) e divide a execução em Sprints focadas na entrega progressiva de valor: mapeamento do fluxo, desenvolvimento de uma interface web (HTML/C#) para CRUD de rematrícula e implementação de diretrizes de conformidade com a LGPD e Segurança da Informação. Como resultado, busca-se um processo mais flexível, transparente e alinhado aos padrões regulatórios vigentes."

- Propor melhorias no processo de segurança da informação


 
## Justificativa

[Aqui a equipe deve descrever a importância ou a motivação para trabalhar com o problema definido. Indique as razões pelas quais a equipe escolheu o problema e definiu os objetivos.

Devem ser apresentados dados de fontes relevantes e confiáveis sobre o problema, inserindo-o como alvo de estudo. Sugere-se que a equipe utilize questionários, entrevistas e dados estatísticos, que devem ser apresentados, com o objetivo de esclarecer detalhes do problema que será abordado pela equipe.]
