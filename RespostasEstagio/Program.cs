//Questão 1:  Soma ----------------------------------------------------------------------------------------------------------------

int indice = 13, soma = 0;

Console.WriteLine("Questão 1: Soma");
Console.WriteLine("int INDICE = 13, SOMA = 0, K = 0;\r\r\nenquanto K < INDICE faça\r\r\n{\r\r\nK = K + 1;\r\r\nSOMA = SOMA + K;\r\r\n}\r\r\nimprimir(SOMA);");
for (int k = 0; k < indice; k++)
{
    soma = soma + k;
}
Console.WriteLine("\nO resultado final é: " + soma);
Console.WriteLine("\n--------------\n");


//Questão 2: Fibonacci -------------------------------------------------------------------------------------------------------------

Console.WriteLine("Questão 2: Fibonacci");
Console.Write("Digite um número para saber se pertence a sequencia: ");
int n1 = int.Parse(Console.ReadLine());

if (n1 == 0)
{
    n1 = 1;
}
int fibo = n1, n2 = 0;

if (fibo != 1)
{
    Console.WriteLine("Este número não pertence a Sequência Fibonacci.");
}
else
{
    Console.Write("Sequência Fibonacci: ");
    for (int i = 0; i < 10; i++)
    {
        int n3 = n2 + fibo;
        fibo = n2;
        n2 = n3;

        Console.Write(n3 + " ");
    }
}
Console.WriteLine("\n\n--------------\n");


//Questão 3: Descubra a lógica -------------------------------------------------------------------------------------------------------
Console.WriteLine("\nQuestão 3: Descubra a lógica");

// a) 1, 3, 5, 7, ___ ~~ Números Ímpares
Console.Write("a) Números Ímpares: ");

for (int i = 0; i <= 15; i++)
{
    if (i % 2 != 0)
    {
        Console.Write(i + " ");
    }
}
Console.WriteLine();

// b) 2, 4, 8, 16, 32, 64, ____ ~~ Multiplicação 
Console.Write("\nb) Multiplicado por 2: ");
int numeroParaMultiplicar = 2;
int multi = 0;
Console.Write(numeroParaMultiplicar + " ");
for (int i = 0; i <= 5; i++)
{
    multi = numeroParaMultiplicar * 2;
    Console.Write(multi + " ");
    numeroParaMultiplicar = multi;
}
Console.WriteLine();

// c) 0, 1, 4, 9, 16, 25, 36, ____ ~~ Elevado a si mesmo, sequencia numérica 
Console.Write("\nc) Números elevados a si mesmo: ");
double elevado = 0;
for (int i = 0; i <= 7; i++)
{
    elevado = i * i;
    Console.Write(elevado + " ");
}
Console.WriteLine();


// d) 4, 16, 36, 64, ____ ~~ Elevado ao quadrado, numeros pares
Console.Write("\nd) Números pares elevados ao quadrado: ");
int quadrado = 0;
for (int i = 0;i <= 10; i++)
{
    if ((i % 2) == 0)
    {
        quadrado = i * i;
        Console.Write(quadrado + " ");
    }
}
Console.WriteLine();

// e) 1, 1, 2, 3, 5, 8, ____ ~~ Fibonacci -> Igual questão 2
Console.Write("\ne) Sequência Fibonacci: ");
n1 = 1; fibo = n1; n2 = 0;
for (int i = 0; i < 7; i++)
{
    int n3 = n2 + fibo;
    fibo = n2;
    n2 = n3;

    Console.Write(n3 + " ");
}
Console.WriteLine();

// f) 2,10, 12, 16, 17, 18, 19, ____
// Esta última não consegui pegar a lógica :(
Console.WriteLine("\nf) não entendi a sequência, sem resposta");
Console.WriteLine("\n--------------\n");


// Questão 4: Descobrir lâmpadas ------------------------------------------------------------------------------------------------------
Console.WriteLine("\nQuestão 4: 3 interruptores, 3 lâmpadas, 2 chances\n");
Console.WriteLine("Esta questão tem sido discutida por muito tempo, e os passos corretos seriam:");
Console.WriteLine("1) Ligar interruptor 01;");
Console.WriteLine("2) Esperar 30 segundos;");
Console.WriteLine("3) Desligar o interruptor 01;");
Console.WriteLine("4) Ligar interruptor 02;");
Console.WriteLine("5) Deslocar-se para sala 01;");
Console.WriteLine("6) Verificar o estado da lâmpada 01 e registrar (se: está acesa || (apagada && gelada) || (apagada e quente);");
Console.WriteLine("7) Deslocar-se para sala 02;");
Console.WriteLine("8) Verificar o estado da lâmpada 02 e registrar (se: está acesa || (apagada && gelada) || (apagada e quente);");
Console.WriteLine("Com isto, você teria algumas questões:");
Console.WriteLine("- A sala com a lâmpada apagada e gelada, pertence ao interruptor 03, intocado.");
Console.WriteLine("- A sala com a lâmpada apagada e quente, pertence ao interruptor 01, o primeiro ligado e desligado.");
Console.WriteLine("- A sala com a lâmpada acesa, pertence ao interruptor 02.");
Console.WriteLine("\nExemplo de resultado:");
Console.WriteLine("Se lâmpada 01 == apagada && quente; interruptor 01 == lâmpada 01;");
Console.WriteLine("Se lâmpada 02 == acesa; interruptor 02 == lâmpada 02;");
Console.WriteLine("interruptor 03 == lâmpada 03");

Console.WriteLine("\nObs.: Como a questão não especificava que resolvesse com programação, fiquei confuso em como responder, mas esta é minha resposta.");
Console.WriteLine("\n--------------\n");


// Questão 5: Inverter Caracteres ------------------------------------------------------------------------------------------------------
Console.WriteLine("\nQuestão 5: Inverter Caracteres:\n");
Console.Write("Escreva o que quiser: ");
string texto = Console.ReadLine();
string textoInvertido = InverterString(texto);
Console.WriteLine("String original: " + texto);
Console.WriteLine("String invertida: " + textoInvertido);
Console.ReadLine();

static string InverterString(string texto)
{
    char[] caracteres = texto.ToCharArray(); 
    int comprimento = caracteres.Length;
    char[] caracteresInvertidos = new char[comprimento];

    for (int i = 0; i < comprimento; i++)
    {
        caracteresInvertidos[i] = caracteres[comprimento - i - 1];
    }

    return new string(caracteresInvertidos); 
}