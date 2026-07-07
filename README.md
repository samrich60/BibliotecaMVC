# 📚 Biblioteca Municipal — Sistema de Gerenciamento

Sistema web desenvolvido com **ASP.NET Core MVC (C#)** para gerenciamento de acervo de uma biblioteca municipal.

🔗 **Acesse online:** [https://bibliotecamvc.onrender.com](https://bibliotecamvc.onrender.com)

> ⚠️ O projeto está hospedado no plano gratuito do [Render](https://render.com). Isso significa que:
> - O serviço "dorme" após alguns minutos sem acesso — a primeira requisição depois disso pode demorar cerca de 1 minuto para responder, enquanto o servidor acorda.
> - O banco de dados (SQLite) não é persistente nesse plano: os livros cadastrados podem ser perdidos quando o serviço reinicia. Para fins de demonstração isso é normal e esperado.

---

## 🚀 Tecnologias Utilizadas

- **C# / ASP.NET Core MVC** (.NET 8)
- **Entity Framework Core**
- **SQLite**
- **Bootstrap 5**
- **Bootstrap Icons**
- **Docker** — containerização para deploy
- **Render** — hospedagem em nuvem (plano gratuito)

---

## 📋 Funcionalidades

### Área Pública
- Página inicial com apresentação da biblioteca
- Página Sobre com história e missão
- Acervo com listagem, busca e filtro por categoria
- Página de Contato com formulário e informações

### Área Administrativa
- Login seguro com controle de sessão
- Dashboard com resumo do acervo
- Cadastro de novos livros
- Edição de livros existentes
- Exclusão de livros com confirmação
- Pesquisa de livros por título, autor ou categoria

---

## 🗂️ Estrutura do Projeto

```
BibliotecaMVC - Copia/              ← raiz do repositório
├── .dockerignore
├── BibliotecaMVC.slnx
└── BibliotecaMVC/
    ├── Dockerfile              # Build da imagem para deploy (Render/Docker)
    ├── Program.cs              # Configuração do app (porta, pipeline, DB)
    ├── Controllers/
    │   ├── HomeController.cs      # Páginas públicas
    │   ├── AdminController.cs     # Login e dashboard
    │   └── LivrosController.cs    # CRUD de livros
    ├── Models/
    │   ├── Livro.cs               # Model de livro
    │   ├── Admin.cs               # Model de administrador
    │   └── BibliotecaContext.cs   # Contexto do banco
    ├── Views/
    │   ├── Home/                  # Views públicas
    │   ├── Admin/                 # Views administrativas
    │   ├── Livros/                # Views do CRUD
    │   └── Shared/                # Layout e parciais
    └── wwwroot/                   # Arquivos estáticos
```

---

## ▶️ Como Executar Localmente

1. Clone o repositório:
```bash
   git clone https://github.com/samrich60/BibliotecaMVC.git
```
2. Abra no Visual Studio 2022
3. Execute as migrations:
```
   Update-Database
```
4. Rode o projeto com **F5**

---

## 🐳 Como Executar com Docker

Também é possível rodar o projeto localmente via container, exatamente como ele roda em produção:

```bash
cd "BibliotecaMVC - Copia"
docker build -f BibliotecaMVC/Dockerfile -t bibliotecamvc .
docker run -p 8080:8080 bibliotecamvc
```

Depois acesse `http://localhost:8080` no navegador.

---

## ☁️ Deploy no Render

O projeto está configurado para deploy automático via Docker no [Render](https://render.com):

1. Crie um **Web Service** no Render conectado a este repositório GitHub.
2. Configure:
   - **Language/Runtime:** Docker
   - **Dockerfile Path:** `BibliotecaMVC/Dockerfile`
   - **Instance Type:** Free
3. A cada `push` na branch principal, o Render refaz o build e publica a nova versão automaticamente.

---

## 🔐 Acesso Administrativo

| Usuário | Senha    |
|---------|----------|
| admin   | admin123 |

---

## 📸 Páginas do Sistema

| Página | Descrição |
|--------|-----------|
| `/` | Página inicial |
| `/Home/Sobre` | Sobre a biblioteca |
| `/Home/Acervo` | Acervo público |
| `/Home/Contato` | Contato |
| `/Admin/Login` | Login administrativo |
| `/Admin/Dashboard` | Painel do admin |
| `/Livros` | Gerenciar livros |

---

## 👨‍💻 Desenvolvido por

Sammy Richard Alves — Projeto Final de Programação Web II ministrada pelo professor Ruben Prado.
