using PROVA_18_06;
Professor prof = new Professor("Flexa",150, 150000);
Aluno aluno = new Aluno("Eduardo",17, 10);

prof.ExibirInfo();
aluno.ExibirInfo();

//Questão 1:
//A Herança na POO é quando existem as classes "Pai" e "Filho" como chamamos, Pai é a classe que contém propriedades e métodos "universais", na qual as classes Filho poderão herdá-las e reutilizá-las
//como por exemplo, "Animal" é uma classe Pai dos Filhos "Cachorro" e "Gato", pois ambos compartilham das mesmas propriedades.

//A vantagem disso é o reaproveitamento das métodos e propriedades, melhorando a estrutura do código e respeitando as boas práticas.



//Questão 2:
//Implementação nas Classes "Professor" e "Aluno"

//Polimorfismo é o conceito de POO que aborda as múltiplas formas na qual um método pode ser abordado e adaptado conforme a necessidade, ele se aplica nas classes Filho herdadas da classe Pai. 

//Override é quando o método precisa ser sobrescrito para se adaptar as necessidades da classe, inseri nas duas classes para poder aplicar a chamada de forma distinta na Program.


// Questão 3:
Estagiario estagiario = new Estagiario("Eduardo", "05820709020", 1000);
Gerente gerente = new Gerente("Eduardo", "05820709020", 10000);
FuncionarioComum funcComum = new FuncionarioComum("Eduardo", "05820709020", 5000);

estagiario.ExibirDados();
gerente.ExibirDados();
funcComum.ExibirDados();
