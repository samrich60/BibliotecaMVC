# 📚 Biblioteca Municipal — Sistema de Gerenciamento

Sistema web desenvolvido com **ASP.NET Core MVC (C#)** para gerenciamento de acervo de uma biblioteca municipal.

---

## 🚀 Tecnologias Utilizadas

- **C# / ASP.NET Core MVC** — estrutura principal
- **Entity Framework Core** — ORM para banco de dados
- **SQLite** — banco de dados local
- **Bootstrap 5** — estilização e responsividade
- **Bootstrap Icons** — ícones

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

BibliotecaMVC/

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

---

## ▶️ Como Executar

1. Clone o repositório:
```bash
git clone https://github.com/SEU_USUARIO/BibliotecaMVC.git
```

2. Abra no Visual Studio 2022

3. Execute as migrations:
Update-Database

4. Rode o projeto com **F5**

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
