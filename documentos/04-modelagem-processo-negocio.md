# 4\. MODELAGEM DO PROCESSO DE NEGÓCIO (Etapa 2)

**4. Modelagem do Processo de negócio**

**4.1 Mapeamento dos Processos Atuais/Existentes (Foco em Segurança)**

O processo selecionado é a Rematrícula Acadêmica do Instituto Politécnico da PUC Minas (IPUC), realizado por meio do portal e do SGA e o processo técnico de Inventário de Ativos de TI (automatizado por meio de um script em C#).  

**Entradas:**

* **Rematrícula:** Credenciais institucionais do aluno (login e senha), documentos digitalizados para validação e dados acadêmicos/financeiros pré-existentes na base de dados.

* **Inventário de Ativos**: Parâmetros de consulta do sistema operacional Windows e a seleção do usuário no menu interativo (1. Hardware, 2. Software, 3. Hardware e Software).

**Sequência de Atividades (Processamento):**

1. Acesso do estudante ao portal web (Front-end em HTML) com autenticação segura.    
2. Exibição das turmas disponíveis, seleção de disciplinas e horários pelo aluno.  
4. Assinatura digital do contrato de prestação de serviços educacionais e emissão/baixa do boleto bancário.  

**Saída:** Efetivação da rematrícula com alocação oficial do aluno nas turmas, emissão do comprovante digital e atualização imediata do banco de dados institucional.  

**Recursos e Tecnologias:** Navegador web para exibição do protótipo em HTML, ambiente Microsoft Windows com PowerShell para execução do script desenvolvido em C# e armazenamento local em arquivos de texto.

**Normas, Padrões e Conformidade Observados:** O processo observa a LGPD (Lei nº 13.709/2018) na proteção de dados pessoais e financeiros, o Marco Civil da Internet (Lei nº 12.965/2014) na guarda segura de logs de acesso, a MP 2.200-2/2001 para validade jurídica do contrato eletrônico, e as diretrizes de segurança baseadas na ISO/IEC 27001/27002 e NIST CSF aplicadas à gestão de ativos e boas práticas de desenvolvimento.

**4.2 Mapeamento da Proposta de Processos (Otimizações, Gargalos e Segurança)**

Para eliminar os gargalos operacionais identificados (como instabilidades e quedas do portal nos picos de acesso, duplicação de dados e riscos de conformidade), propõem-se as seguintes otimizações:  

**Otimização de Infraestrutura e Escalabilidade (Disponibilidade):**
  
* Substituição de estruturas locais sobrecarregadas por uma arquitetura em nuvem escalável (como Microsoft Azure) com balanceamento de carga e auto-scaling (expansão automática de instâncias nos períodos de pico de rematrícula).  

* Implementação de Firewall de Borda (ex: Cloudflare Pro com WAF e proteção contra DDoS) para filtrar acessos maliciosos antes que cheguem ao portal.  

**Aprimoramento de Controles Tecnológicos e de Dados (Integridade e Confidencialidade):**

* Evolução do protótipo HTML para um sistema dinâmico integrado a um Back-end seguro e banco de dados relacional com transações baseadas em propriedades ACID, garantindo o registro efetivo das matrículas e evitando perda de vagas.

* Implementação de criptografia ponta a ponta na comunicação (HTTPS/TLS) e autenticação multifator (MFA) para alunos e operadores.  

* Conscientização contra Shadow IT:
Direcionamento do uso de ferramentas corporativas oficiais da PUC para o tratamento de dados confidenciais, coibindo o uso inadequado de aplicativos de mensagens pessoais e IAs públicas para dados de alunos e pesquisas (em conformidade com a LGPD).  




