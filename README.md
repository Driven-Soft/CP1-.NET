# CP1 - .NET

### Integrantes do grupo

- Felipe Bezerra Beatrici - RM564723
- Max Hayashi Batista - RM563717
- Henrique Cunha Torres - RM565119

<hr/>

### Domínio escolhido

- Biblioteca

<hr/>

### Entidades modeladas

- User (Usuários)
- Loan (Empréstimos)
- Book (Livros)
- Author (Autores)
- Publisher (Editoras)
- Category (Categorias)

<hr/>

### Resumo dos relacionamentos

- User (1:N) Loan
  - Um usuário pode ter zero ou mais empréstimos.
  - Cada empréstimo pertence a um único usuário.
- Book (1:1) Loan
  - Um livro pode ter no máximo um empréstimo.
  - Cada empréstimo pertence a um único livro.
- Publisher (1:N) Book
  - Uma editora pode publicar vários livros.
  - Cada livro pertence a uma única editora.
- Book (N:N) Author
  - Um livro pode ter vários autores.
  - Um autor pode estar em vários livros.
- Book (N:N) Category
  - Um livro pode pertencer a várias categorias.
  - Uma categoria pode conter vários livros.
