using RegistroDeAcesso.Modelos;
using RegistroDeAcesso.Relatorios;

Entrega entregaDePizza = new Entrega(representante: "Marcela");
Colaborador joseDaAlura = new Colaborador(idAcesso: 25);
Colaborador mariaDaAcme = new Colaborador(idAcesso: 14);
Visitante filhoDeMaria = new Visitante(nome: "Pedro", documento: "12938732", sala: "1002");

RelatorioDeAcesso acessoMensal = new RelatorioDeAcesso();
acessoMensal.RegistrarEntrada(entregaDePizza);
acessoMensal.RegistrarEntrada(joseDaAlura);
acessoMensal.RegistrarEntrada(mariaDaAcme);
acessoMensal.RegistrarEntrada(filhoDeMaria);

// ao final do mês...
acessoMensal.ExibirRegistroDoMes();