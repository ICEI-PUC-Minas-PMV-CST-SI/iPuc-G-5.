
## Objetivos

**2.1 Objetivo Geral**

\-A visão dos processos de negócios organizacionais voltada para o core de rematrícula integra diretamente a segurança da informação ao ciclo operacional da instituição, conectando o fluxo estratégico às ferramentas desenvolvidas: o protótipo em HTML e o gerenciamento de dados via CRUD em C#.
.

**2.2 Objetivos Específicos**

● O contexto do negócio do core de rematrícula é o ambiente operacional da instituição de ensino focado em renovar a matrícula do aluno com eficiência e proteção de dados, o fluxo de rematrícula funciona na prática, identificando as necessidades das partes envolvidas, os riscos operacionais e de segurança, e a função de cada tecnologia no processo.

●  As principais normas de segurança da informação (como ISO/IEC 27001/27002 e NIST CSF) organizam suas regras em 4 categorias essenciais.
​No sistema de rematrícula, esses itens são aplicados assim:

​1. Controles Tecnológicos (Proteção do Software)
​Desenvolvimento Seguro: Escrever o código C# (CRUD) de forma a bloquear invasões (ex: validar entradas contra SQL Injection).
​Criptografia: Proteger a comunicação no site HTML (usando HTTPS) e codificar dados sensíveis de alunos no banco de dados.
​Controle de Acesso: Garantir que o aluno só veja a própria rematrícula, enquanto a secretaria gerencia as turmas.

2. Controles Organizacionais (Regras e Processos)
​Políticas de Segurança: Regras institucionais sobre quem pode visualizar, alterar ou excluir registros acadêmicos e financeiros.
​Gestão de Ativos: Mapear e proteger o código-fonte, servidores e bases de dados do sistema.

​3. Controles Operacionais (Monitoramento e Resposta)
​Auditoria de Logs: Registrar histórico de quem executou cada ação de Criar, Atualizar ou Deletar no CRUD em C#.
​Backups e Recuperação: Garantir cópias de segurança atualizadas para o sistema não parar durante o período de rematrícula.

​4. Controles Pessoas (Treinamento)
​Conscientização: Treinar a equipe que opera o sistema para não cair em golpes de captura de senhas (phishing).


Modelo de Topologia
A arquitetura do nosso sistema segue um modelo estruturado em camadas para garantir organização, facilidade de manutenção e segurança das informações acadêmicas:
Camada de Apresentação (Front-end): É a interface web desenvolvida em HTML onde o aluno acessa o sistema, visualiza as disciplinas disponíveis e preenche os dados de renovação de matrícula.
Camada de Negócio e Lógica (Back-end): Desenvolvida em C#, é o "motor" do sistema. Ela processa as requisições enviadas pelo aluno, aplica as regras de negócio da instituição e gerencia as operações do CRUD (Create, Read, Update, Delete — Criar, Ler, Atualizar e Excluir).
Camada de Dados (Banco de Dados): Onde ficam armazenados de forma centralizada e segura os registros dos alunos, históricos e dados financeiros, protegidos por controles de acesso.
Como os dados trafegam
No projeto, o mapeamento desse processo funciona de forma integrada:
1. Acesso do Aluno: O estudante entra na página em HTML, insere suas credenciais de forma segura (com autenticação) e solicita a rematrícula.
2. Tratamento no Back-end: O sistema em C# recebe essa solicitação, valida se o aluno possui pendências e processa a alteração no banco de dados através das funções do CRUD.
3. Resposta Visual: O sistema retorna uma confirmação imediata na interface web para o usuário, garantindo que o ciclo de renovação foi concluído com sucesso.


o Instituto Politécnico (IPUC) da PUC Minas —, a cultura organizacional :
E a dimensão religiosa (humanista e católica) exercem um impacto direto nas operações, na missão e nos sistemas de tecnologia da instituição.  
Para o trabalho de faculdade/documentação do projeto, você pode apresentar a avaliação do impacto cultural e religioso dividida nos seguintes pontos estratégicos:
Missão Institucional e Valores Cristãos
Formação Humanista: A missão do IPUC é formar profissionais e cidadãos éticos, aliando a excelência técnica em Engenharia e Tecnologia à geração de conhecimento pautada nos valores cristãos.  
Impacto no Dia a Dia: A cultura católica humanista se reflete no compromisso com a solidariedade, a responsabilidade social e a sustentabilidade, orientando as decisões operacionais e o respeito à dignidade humana.  

- Desenvolver um projeto de intervenção da estrutura organizacional utilizando métodos ágeis de gerência de projetos.
- Propor melhorias no processo de segurança da informação

Observação: a fim de desenvolver um planejamento eficiente sobre a definição do problema e objetivos do trabalho, fique atento às informações que serão levantadas. Pois um levantamento de informações ruins, levarão a análises ruins. Então, busque variáveis confiáveis para o desenvolvimento do projeto.

 
## Justificativa

[Aqui a equipe deve descrever a importância ou a motivação para trabalhar com o problema definido. Indique as razões pelas quais a equipe escolheu o problema e definiu os objetivos.

Devem ser apresentados dados de fontes relevantes e confiáveis sobre o problema, inserindo-o como alvo de estudo. Sugere-se que a equipe utilize questionários, entrevistas e dados estatísticos, que devem ser apresentados, com o objetivo de esclarecer detalhes do problema que será abordado pela equipe.]
