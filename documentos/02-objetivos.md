
## Objetivos

**2.1 Objetivo Geral:**

A visão dos processos de negócios organizacionais voltada para o core de rematrícula integra diretamente a segurança da informação ao ciclo operacional da instituição, conectando o fluxo estratégico às ferramentas desenvolvidas: o protótipo em HTML e o gerenciamento de dados via CRUD em C#.
.

**2.2 Objetivos Específicos:**

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

**2.Como os dados trafegam:**

No projeto, o mapeamento desse processo funciona de forma integrada:
1. Acesso do Aluno: O estudante entra na página em HTML, insere suas credenciais de forma segura (com autenticação) e solicita a rematrícula.
2. Tratamento no Back-end: O sistema em C# recebe essa solicitação, valida se o aluno possui pendências e processa a alteração no banco de dados através das funções do CRUD.
3. Resposta Visual: O sistema retorna uma confirmação imediata na interface web para o usuário, garantindo que o ciclo de renovação foi concluído com sucesso.


**3.Instituto Politécnico (IPUC) da PUC Minas —, a cultura organizacional :**

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


**Propostas de melhorias na segurança da informação** 

• Para o Portal e Sistemas: Implementar autenticação em duas etapas (MFA) para proteger as senhas e adotar balanceamento de carga para acabar com a lentidão no pico de rematrícula.
• Para as Comunicações (WhatsApp e Nuvem): Criar um guia prático orientando que grupos de WhatsApp e IAs públicas sirvam apenas para avisos gerais, deixando o compartilhamento de relatórios de notas, históricos e pesquisas confidenciais exclusivamente para as ferramentas oficiais da PUC.
• Para Computadores e Dispositivos: Manter os programas dos laboratórios atualizados e desativar o início automático (Autorun) de pendrives nas portas USB.
• Para a Infraestrutura Física: Colocar um ar-condicionado reserva na sala de servidores para evitar superaquecimento e instalar calhas protetoras sob os canos no teto do arquivo físico para prevenir danos por vazamentos.
• Para as Pessoas: Promover avisos e dicas rápidas sobre Phishing e privacidade (LGPD) no próprio portal acadêmico, alertando a comunidade sobre golpes por e-mail.



 
## Justificativa

A modernização do sistema de rematrícula do IPUC é essencial para acabar com a lentidão e as quedas do portal nos períodos de maior acesso. Embora a digitalização tenha eliminado os papéis, o grande volume de acessos simultâneos sobrecarrega a estrutura atual, gerando erros que prejudicam os alunos e atrasam o trabalho da secretaria.
Este projeto se justifica por três motivos principais:
• Estabilidade: Evitar que o sistema caia nos dias de pico, garantindo que o aluno consiga se matricular sem interrupções.
• Organização dos Dados: Padronizar as funções do sistema para eliminar informações duplicadas e atualizar os registros de forma imediata.
• Segurança e Respeito: Proteger os dados dos estudantes contra vazamentos e criar uma página acessível, seguindo os valores éticos e de acolhimento da PUC Minas
      3.1  Histórico 
O Instituto Politécnico (IPUC) é uma unidade acadêmica de grande escala da PUC Minas, situada na região metropolitana de Belo Horizonte. Atua no setor educacional privado e sem fins lucrativos, integrando ensino, pesquisa e extensão focados em Engenharia, Tecnologia e projetos de inovação industrial. Sua missão é formar cidadãos éticos com base em valores cristãos e humanistas; sua visão é ser líder em excelência acadêmica e inovação; e seus valores sustentam-se na ética, solidariedade e inclusão. Estrategicamente, busca modernizar sua estrutura física e digital aliando alta capacitação técnica à responsabilidade social e ambiental (ODS).

A segurança do IPUC baseia-se nas diretrizes da ISO 27001/27002 e do NIST CSF. A TI Central da PUC gerencia os firewalls corporativos, os logs de acesso e a segurança das conexões de rede (HTTPS), enquanto os departamentos locais monitoram a segurança física e trabalhista (NR-12) nos laboratórios e oficinas. A proteção do sistema de rematrícula organiza-se de forma estruturada: controle de acesso por perfis para que o aluno acesse apenas seus dados, armazenamento centralizado e seguro das informações acadêmicas e garantia de backups para a recuperação do sistema em caso de incidentes.

• Instabilidade e Sobrecarga no Portal: Quedas frequentes e lentidão do portal nos períodos de pico devido ao excesso de acessos simultâneos, gerando falhas na sincronização das informações e duplicação de dados entre os setores administrativos.
• Ameaças de Engenharia Social (Phishing): Risco elevado de captura de senhas e roubo de credenciais da equipe que opera o sistema e dos alunos por falta de treinamentos de conscientização e da não obrigatoriedade da verificação em duas etapas (MFA).
• Vulnerabilidades e Brechas no Portal: Risco de acessos não autorizados por terceiros ou usuários mal-intencionados para manipulação de registros de notas ou grades horárias, agravado pelo uso de softwares e sistemas desatualizados nos laboratórios.
• TI Invisível (Shadow IT) Crítica: Uso não homologado de contas pessoais de armazenamento (Google Drive/Sheets), grupos de WhatsApp e ferramentas públicas de inteligência artificial para tratar históricos de alunos e dados confidenciais de pesquisas, violando a LGPD.
• Gargalos Físicos de Infraestrutura: Risco crônico de superaquecimento dos servidores por falta de redundância e de sensores no ar-condicionado, e perigo iminente de inundação do arquivo físico de matrículas por tubulações hidráulicas expostas no teto.
Mecanismos e Tecnologias de Segurança
Controle de Acesso: Autenticação centralizada (Single Sign-On) vinculada às credenciais institucionais para restrição por perfil de usuário.
Segurança de Perímetro e Rede: Uso de firewalls de próxima geração (NGFW), VPNs criptografadas para acesso remoto e segmentação de redes.
Proteção de Dados e Continuidade: Criptografia de dados em trânsito (HTTPS/TLS) e em repouso, combinada com rotinas automatizadas de backup redundante.
     5. Processos da Organização
Suporte e Atendimento: Triagem e resolução de chamados de TI e apoio à utilização das plataformas e laboratórios.
Gestão de Usuários e Permissões: Ciclo de vida das contas de alunos e professores, provisionando e revogando acessos aos sistemas.
Gestão de Recursos Acadêmicos: Planejamento e alocação de infraestrutura, softwares e equipamentos para atividades práticas.
Auditoria e Conformidade: Monitoramento contínuo de logs de acesso e análise de segurança para atender à LGPD.
     6. Disponibilidade, Integridade e Confidencialidade
Disponibilidade: Garantia de que portais, sistemas e laboratórios estejam acessíveis quando necessário, utilizando servidores redundantes e planos de contingência.
Integridade: Proteção dos dados cadastrais e acadêmicos contra alterações não autorizadas, assegurada por registros de auditoria (logs) e controle de versão.
Confidencialidade: Restrição de informações sensíveis apenas a pessoas autorizadas, com base em perfis de acesso (RBAC) e criptografia.

