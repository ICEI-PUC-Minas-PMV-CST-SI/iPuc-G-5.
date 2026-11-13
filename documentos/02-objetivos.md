
## Objetivos

**2.1 Objetivo Geral:**

A visão dos processos de negócios organizacionais voltada para o core de rematrícula e gestão institucional integra diretamente a segurança da informação ao ciclo operacional, conectando o fluxo estratégico às ferramentas desenvolvidas: o protótipo em HTML (para a interface web) e o Script em C# executado via PowerShell (para o inventário de computadores com Windows).

**2.2 Objetivos Específicos:**

● O contexto do negócio do core de rematrícula é o ambiente operacional da instituição de ensino focado em renovar a matrícula do aluno com eficiência e proteção de dados, enquanto o script de inventário em C# atua na governança e suporte aos ativos tecnológicos da instituição. O fluxo funciona na prática, identificando as necessidades das partes envolvidas, os riscos operacionais e de segurança, e a função de cada tecnologia no processo.

● As principais normas de segurança da informação (como ISO/IEC 27001/27002 e NIST CSF) organizam suas regras em 4 categorias essenciais. No sistema e nas ferramentas da instituição, esses itens são aplicados assim:

**​1. Controles Tecnológicos (Proteção do Software)**

​**Desenvolvimento Seguro:** Escrever o código do script em C# de forma robusta e segura para execução controlada no PowerShell em ambientes Windows.

**Controle de Acesso:** Garantir que apenas usuários autorizados executem o script de inventário nas máquinas e que o aluno só veja a própria rematrícula no portal web.

**2. Controles Organizacionais (Regras e Processos)**

​**Políticas de Segurança:** Regras institucionais sobre quem pode visualizar, alterar ou excluir registros acadêmicos e financeiros.
​
**Gestão de Ativos:** Mapear e proteger o código-fonte, servidores e bases de dados do sistema.

**​3. Controles Operacionais (Monitoramento e Resposta)**

​**Registro de Inventário (Substituindo a Auditoria de Logs):** O script em C# gera o arquivo localmente, servindo como o registro/histórico estruturado do inventário de hardware e software daquela máquina específica.

**Preservação de Dados (Substituindo o Backup Automático):** Como o sistema não utiliza banco de dados, os dados coletados ficam salvos de forma local no arquivo  gerado pelo script, ficando a cargo do usuário o armazenamento ou cópia manual do arquivo, caso necessário.

**​4. Controles Pessoas (Treinamento)**

​**Conscientização:** Treinar a equipe que opera o sistema para não cair em golpes de captura de senhas (phishing).

**1.Modelo de Topologia:**

A arquitetura do nosso projeto é enxuta e focada nas entregas propostas:
**Camada de Apresentação/Interface (Front-end):** Protótipo web desenvolvido em HTML que simula a interface do processo de rematrícula.

**Camada de Automação e Coleta (Script C#):** Script desenvolvido em C# executado no PowerShell em sistemas Windows, contendo o menu interativo (1. Hardware, 2. Software, 3. Hardware e Software).

**Camada de Armazenamento Local:** Os dados coletados pelo script de inventário não utilizam banco de dados relacional, sendo salvos diretamente de forma estruturada em um arquivo de texto com extensão

**2.Como os dados trafegam:**

**Acesso do Aluno:** Funciona como uma interface de prototipagem/apresentação para simular o fluxo de atendimento ao aluno na rematrícula.
**Resposta Visual:** O sistema retorna uma confirmação imediata na interface web para o usuário, garantindo que o ciclo de renovação foi concluído com sucesso.
**No Script C#:** O usuário executa o script via PowerShell, escolhe uma das opções do menu, e o programa coleta as informações da máquina Windows, gerando e salvando o resultado diretamente no arquivo

**3.Instituto Politécnico (IPUC) da PUC Minas —, a cultura organizacional :**

A dimensão humanista e católica da instituição orienta as operações, a missão e o desenvolvimento tecnológico no ambiente acadêmico:

**Missão Institucional e Valores Cristãos:** A missão do IPUC é formar profissionais e cidadãos éticos, aliando a excelência técnica em Engenharia e Tecnologia à geração de conhecimento pautada nos valores cristãos.
**Impacto no Dia a Dia:** A cultura humanista reflete-se no compromisso com a solidariedade, a responsabilidade social e o respeito à dignidade humana. 

**4.Impacto nos Processos de Atendimento e Negócio:**

Tratamento Humanizado ao Aluno: A cultura institucional exige que processos administrativos e financeiros (como a rematrícula) priorizem o respeito ao estudante. Em situações de pendência ou inadimplência, a política institucional busca a negociação amigável em vez de punições pedagógicas.  
Inclusão e Diversidade: A responsabilidade social da instituição orienta a inclusão de diversos perfis de estudantes (como beneficiários do Prouni) e exige uma atuação focada em acolhimento e acessibilidade.  

**5.Impacto na Tecnologia e na Segurança da Informação:**

A identidade cultural e ética da universidade se traduz em diretrizes práticas de TI:
* Privacidade e Proteção de Dados: A ética cristã de respeito ao indivíduo alinha-se diretamente com o cumprimento da LGPD, garantindo que os dados pessoais de alunos e professores sejam coletados com transparência e protegidos contra vazamentos.  
- Desenvolvimento Ético: Na criação do código em C# e da página em HTML, a integridade exige autoria própria, transparência sobre o que o sistema realmente faz e respeito às boas práticas de programação.    

​O presente projeto de intervenção apresenta o desenvolvimento de duas soluções práticas no contexto do IPUC Engenharia: um protótipo de interface em HTML para simular o fluxo de rematrícula e um script em C# executado via PowerShell para realizar o inventário de hardware e software em computadores Windows, salvando os dados em arquivo .dat. A organização do trabalho divide-se entre o desenvolvimento técnico dessas ferramentas e a análise conceitual de processos organizacionais, cultura institucional e diretrizes de Segurança da Informação e LGPD.

**Propostas de melhorias na segurança da informação** 

• Para o Portal e Sistemas: Implementar autenticação em duas etapas (MFA) para proteger as senhas e adotar balanceamento de carga para acabar com a lentidão no pico de rematrícula.
• Para as Comunicações (WhatsApp e Nuvem): Criar um guia prático orientando que grupos de WhatsApp e IAs públicas sirvam apenas para avisos gerais, deixando o compartilhamento de relatórios de notas, históricos e pesquisas confidenciais exclusivamente para as ferramentas oficiais da PUC.
• Para Computadores e Dispositivos: Manter os programas dos laboratórios atualizados e desativar o início automático (Autorun) de pendrives nas portas USB.
• Para a Infraestrutura Física: Colocar um ar-condicionado reserva na sala de servidores para evitar superaquecimento e instalar calhas protetoras sob os canos no teto do arquivo físico para prevenir danos por vazamentos.
• Para as Pessoas: Promover avisos e dicas rápidas sobre Phishing e privacidade (LGPD) no próprio portal acadêmico, alertando a comunidade sobre golpes por e-mail.



 
## Justificativa

Este projeto justifica-se pela necessidade de unir a prática de programação à visão de processos organizacionais e segurança da informação:

* Automação de Inventário: O script em C# para PowerShell agiliza o levantamento de hardware e software em máquinas Windows, gerando registros padronizados em .dat sem a necessidade de verificação manual peça por peça.

- Prototipagem de Processos: O desenvolvimento da tela em HTML permite visualizar e estruturar de forma clara a jornada do aluno na rematrícula antes de investimentos em sistemas complexos.

+ Alinhamento Ético e Técnico: Permite aplicar conceitos fundamentais de governança de TI e proteção de dados desde a concepção de ferramentas simples, respeitando os valores de excelência e responsabilidade da PUC Minas.
