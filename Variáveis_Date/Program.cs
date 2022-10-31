
try
{
    Console.WriteLine(DateTime.Now + "\n\r");  //Imprime a data atual e hora do usuário no console.  

    //___________________________________________________________________________________________________________
    //Descobrindo limites disponíveis para data e hora dentro da aplicação.

    Console.WriteLine("Esse é o valor minimo para data: " + DateTime.MinValue + "\n\r");

    Console.WriteLine("Esse é o valor máximo para data: " + DateTime.MaxValue + "\n\r");

    //___________________________________________________________________________________________________________
    //Manipulando variável de data e hora

    DateTime dataNasc = new DateTime(2022, 10, 31);

    DateTime d = dataNasc.AddDays(1);//Adiciona o valor passado como parâmetro a data escolhida.

    Console.WriteLine("A nova data é: " + d + "\n\r");

    //____________________________________________________________________________________________________________________

    DateTime contagemAno = new DateTime(2022, 12, 31);//Conta quantos dias faltam para chegar a data passada como parÂmetro.

    Console.WriteLine("Faltam " + (contagemAno.Subtract(DateTime.Now).Days + " dias para o ano acabar!"));

}

catch (Exception ex)//O catch tem como parâmentro a classe Exception
{
    Console.WriteLine(" Erro ao executar a aplicação não identificado! " + ex.Message);//Mensagem é exibida ao User em caso de erro.


}


//____________________________________________________________________________

Console.ReadKey();





