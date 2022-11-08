int numero, digito, soma = 0, produto = 1;

Console.WriteLine("Insira um número: ");
numero = Convert.ToInt32(Console.ReadLine());

while(numero > 0)
{
    digito = numero % 10; //encontra o último dígito    
    soma += digito; //Armazenar o digito encontrado
    produto *= digito;
    numero /= 10; //encontra os dígitos restantes
}

Console.WriteLine($"{produto} - {soma} = {produto - soma}");
