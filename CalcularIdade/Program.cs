int idade;

Console.WriteLine("Digite a idade: ");
idade = int.Parse(Console.ReadLine());

if (idade < 0) 
{
    Console.WriteLine("Idade inválida.");
}

else
{
    if (idade < 18) 
    {
        Console.WriteLine("{0} anos, menor de idade.", idade);
    } 

    else
    {
        Console.WriteLine("{0} anos, maior de idade.", idade);
    }


}   