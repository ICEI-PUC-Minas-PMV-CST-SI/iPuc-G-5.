	# 3. DIAGNÓSTICO ORGANIZACIONAL (Etapa 1)
	
	## 3.1 Histórico da Organização
	
	### 1. Apresentação da organização
	
	O Instituto Politécnico (IPUC) é uma unidade acadêmica de grande escala da PUC Minas, situada na região metropolitana de Belo Horizonte. Atua no setor educacional privado e sem fins lucrativos, integrando ensino, pesquisa e extensão com foco em Engenharia, Tecnologia e projetos de inovação industrial.
	
	- **Missão:** formar cidadãos éticos, com base em valores cristãos e humanistas.
	- **Visão:** ser líder em excelência acadêmica e inovação.
	- **Valores:** ética, solidariedade e inclusão.
	
	Estrategicamente, o instituto busca modernizar sua estrutura física e digital, aliando alta capacitação técnica à responsabilidade social e ambiental (ODS).
	
	### 2. Segurança da informação na organização
	
	A segurança do IPUC baseia-se nas diretrizes da ISO 27001/27002 e do NIST CSF. A TI Central da PUC gerencia os firewalls corporativos, os logs de acesso e a segurança das conexões de rede (HTTPS), enquanto os departamentos locais monitoram a segurança física e trabalhista (NR-12) nos laboratórios e oficinas.
	
	A proteção do sistema de rematrícula é estruturada em:
	
	- controle de acesso por perfis, para que o aluno acesse apenas os próprios dados;
	- armazenamento centralizado e seguro das informações acadêmicas;
	- backups, para a recuperação do sistema em caso de incidentes.
	
	### 3. Problemas de segurança da informação
	
	- **Instabilidade e sobrecarga no portal:** quedas e lentidão nos períodos de pico, causadas pelo excesso de acessos simultâneos, com falhas de sincronização e duplicação de dados entre os setores administrativos.
	- **Ameaças de engenharia social (phishing):** risco elevado de captura de senhas e roubo de credenciais da equipe que opera o sistema e dos alunos, por falta de treinamentos de conscientização e pela não obrigatoriedade da verificação em duas etapas (MFA).
	- **Vulnerabilidades e brechas no portal:** risco de acesso não autorizado por terceiros ou usuários mal-intencionados para manipular registros de notas ou grades horárias, agravado pelo uso de softwares e sistemas desatualizados nos laboratórios.
	- **TI invisível (Shadow IT):** uso não homologado de contas pessoais de armazenamento (Google Drive/Sheets), grupos de WhatsApp e ferramentas públicas de inteligência artificial para tratar históricos de alunos e dados confidenciais de pesquisas, o que viola a LGPD.
	- **Gargalos físicos de infraestrutura:** risco crônico de superaquecimento dos servidores, por falta de redundância e de sensores no ar-condicionado, e perigo de inundação do arquivo físico de matrículas por tubulações hidráulicas expostas no teto.
	
	### 4. Mecanismos e tecnologias de segurança
	
	- **Controle de acesso:** autenticação centralizada (Single Sign-On) vinculada às credenciais institucionais, com restrição por perfil de usuário.
	- **Segurança de perímetro e rede:** firewalls de próxima geração (NGFW), VPNs criptografadas para acesso remoto e segmentação de redes.
	- **Proteção de dados e continuidade:** criptografia de dados em trânsito (HTTPS/TLS) e em repouso, combinada com rotinas automatizadas de backup redundante.
	
	### 5. Processos da organização
	
	- **Suporte e atendimento:** triagem e resolução de chamados de TI e apoio ao uso das plataformas e dos laboratórios.
	- **Gestão de usuários e permissões:** ciclo de vida das contas de alunos e professores, com concessão e revogação de acessos aos sistemas.
	- **Gestão de recursos acadêmicos:** planejamento e alocação de infraestrutura, softwares e equipamentos para atividades práticas.
	- **Auditoria e conformidade:** monitoramento contínuo dos logs de acesso e análise de segurança para atender à LGPD.
	
	### 6. Disponibilidade, integridade e confidencialidade
	
	- **Disponibilidade:** garantia de que portais, sistemas e laboratórios estejam acessíveis quando necessário, por meio de servidores redundantes e planos de contingência.
	- **Integridade:** proteção dos dados cadastrais e acadêmicos contra alterações não autorizadas, assegurada por registros de auditoria (logs) e controle de versão.
	- **Confidencialidade:** restrição das informações sensíveis a pessoas autorizadas, com base em perfis de acesso (RBAC) e criptografia.
	
	## 3.2 Sistemas de Informação identificados na empresa
	
	| Software | Setor | Descrição |
	|---|---|---|
	| SGA / portal de rematrícula | Secretaria e registro acadêmico | Sistema que automatiza a rematrícula dos alunos. Sofre lentidão e quedas nos períodos de pico. |
	| AVA (ambiente virtual de aprendizagem) | Ensino (alunos e professores) | Plataforma de apoio às atividades acadêmicas, que deve ser compatível com tecnologias assistivas. |
	| Autenticação centralizada (SSO) | TI Central | Login único com as credenciais institucionais, com acesso restrito por perfil de usuário. |
	| Firewalls NGFW e VPN | TI Central | Proteção do perímetro da rede e acesso remoto seguro, com redes segmentadas. |
	| Rotinas de backup | TI Central | Cópias de segurança automatizadas e redundantes para recuperação em caso de incidentes. |
	| Protótipo de rematrícula do projeto (HTML, C# e banco de dados) | Equipe do projeto | Sistema em camadas (interface web, regras de negócio e dados) com as operações de CRUD. |
	| WhatsApp (grupos) | Vários setores (uso informal) | Usado para comunicação, mas não homologado: risco de Shadow IT e de vazamento de dados. |
	| Google Drive e Google Sheets pessoais | Vários setores (uso informal) | Armazenamento e planilhas fora das ferramentas oficiais, em desacordo com a LGPD. |
	| IAs públicas | Vários setores (uso informal) | Ferramentas externas usadas para tratar dados, sem aprovação, o que expõe informações confidenciais. |
