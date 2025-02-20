//Variables
int opcionMenu, opcionGrados;
int num1, num2, numero;
int numPrimoNoprimo;//para la "validación de números primos"
int sumaPares = 0;//para la "suma de números pares"
string contraseña = "a1b2c3"; //para la "validación de contraseña"
double celsius, fahrenheit; //para la "conversión de temperatura"
string cadena; //para el "contador de vocales"

//Funciones de la "calculadora básica"
int suma(){
    return num1 + num2;}
int resta(){
    return num1 - num2;}
int multiplicacion(){
    return num1 * num2;}
int division(){
    return num1 / num2;}

//Funciones para conversion de temperatura
double celsiusFahrenheit(){
    Console.WriteLine("Ingrese la temperatura en grados Celsius: ");
    celsius = double.Parse(Console.ReadLine());
    fahrenheit = celsius * 9 / 5 + 32;
    return fahrenheit;}
double fahrenheitCelsius(){
    Console.WriteLine("Ingrese la temperatura en grados Fahrenheit: ");
    fahrenheit = double.Parse(Console.ReadLine());
    celsius = (fahrenheit - 32) * 5 / 9;
    return celsius;}

//Función para contar vocales
int contarVocales(string cadena){
    Console.WriteLine("Ingrese una cadena de texto: ");
    cadena = Console.ReadLine() ?? string.Empty;
    int contador = 0;
    for (int i = 0; i < cadena.Length; i++){
        if (cadena[i] == 'a' || cadena[i] == 'e' || cadena[i] == 'i' || cadena[i] == 'o' || cadena[i] == 'u'){
            contador++;}
    }
    return contador;}

//Función para calcular el factorial
int factorial(int n){
    int resultado = 1;
    for (int i = 1; i <= n; i++){
        resultado *= i;}
    return resultado;}

//Función para el paso por referencia
void Intercambiar(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

//Funcion para la tabla de multiplicar
void TablaMultiplicar(int numero){
    for (int i = 1; i <= 10; i++){
        Console.WriteLine($"{numero} x {i} = {numero * i}");}
}

//Menú de opciones
Console.WriteLine("Elija la opcion que deseé");
Console.WriteLine("1. Calculadora Básica");
Console.WriteLine("2. Validación de Contraseña");
Console.WriteLine("3. Números Primos");
Console.WriteLine("4. Suma de Números Primos");
Console.WriteLine("5. Conversión de Temperatura");
Console.WriteLine("6. Contador de Vocales");
Console.WriteLine("7. Cálculo de Factorial");
Console.WriteLine("8. Juego de Adivinanza");
Console.WriteLine("9. Paso por Referencia");
Console.WriteLine("10. Tabla de Multiplicar");
opcionMenu = int.Parse(Console.ReadLine());

//Switch para seleccionar el programa
switch (opcionMenu)
{
    case 1: //Calculadora Básica
        Console.WriteLine("Calculadora Básica seleccionada");
        Console.WriteLine("Ingrese el primer número: ");
        while (!int.TryParse(Console.ReadLine(), out num1)){
            Console.WriteLine("Entrada no válida. Ingrese un número entero: ");}
        Console.WriteLine("Ingrese el segundo número: ");
        while (!int.TryParse(Console.ReadLine(), out num2)){
            Console.WriteLine("Entrada no válida. Ingrese un número entero: ");}

        Console.WriteLine("Ingrese la operación que desea realizar: ");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        while (!int.TryParse(Console.ReadLine(), out opcionMenu) || opcionMenu < 1 || opcionMenu > 4){
            Console.WriteLine("Opción no válida. Ingrese una opción entre 1 y 4: ");}
        switch (opcionMenu){
            case 1:
                Console.WriteLine($"El resultado de la suma es: {suma()}");
                break;
            case 2:
                Console.WriteLine($"El resultado de la resta es: {resta()}");
                break;
            case 3:
                Console.WriteLine($"El resultado de la multiplicación es: {multiplicacion()}");
                break;
            case 4:
                Console.WriteLine($"El resultado de la división es: {division()}");
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
        break;

    case 2://Validación de Contraseña
        Console.WriteLine("Validación de Contraseña seleccionada");
        string? contraseñaIngresada;
        do{
            Console.Write("Ingrese la contraseña: ");
            contraseñaIngresada = Console.ReadLine();
            if (contraseñaIngresada != contraseña){
                Console.WriteLine("Contraseña incorrecta. Intente nuevamente.");
            }
        } while (contraseñaIngresada != contraseña);
        Console.WriteLine("Acceso concedido");
        break;

    case 3://Números Primos
        Console.WriteLine("Números Primos seleccionada");
        Console.WriteLine("Ingrese un número entero: ");
        numPrimoNoprimo = int.Parse(Console.ReadLine());
        bool esPrimo = true;
        for (int i = 2; i <= Math.Sqrt(numPrimoNoprimo); i++){
            if (numPrimoNoprimo % i == 0){
                esPrimo = false;
                break;
            }
        }
        if (esPrimo && numPrimoNoprimo > 1){
            Console.WriteLine("El número es primo");
        }
        else{
            Console.WriteLine("El número no es primo");
        }
        break;

    case 4://Suma de Números Primos
        Console.WriteLine("Suma de Números Primos seleccionada");
        Console.WriteLine("Ingrese números enteros (0 para terminar):");
        while (true){
            numero = int.Parse(Console.ReadLine());
            if (numero == 0){
                break;}
            if (numero % 2 == 0){
                sumaPares += numero;}
        }

        Console.WriteLine($"La suma de todos los números pares ingresados es: {sumaPares}");
        break;

    case 5: //Conversión de Temperatura
        Console.WriteLine("Conversión de Temperatura seleccionada");
        Console.WriteLine("1. Convertir Celsius a Fahrenheit");
        Console.WriteLine("2. Convertir Fahrenheit a Celsius");
        while (!int.TryParse(Console.ReadLine(), out opcionGrados) || opcionGrados < 1 || opcionGrados > 2){
            Console.WriteLine("Opción no válida. Ingrese una opción entre 1 y 2: ");}
        switch (opcionGrados){
            case 1:
                Console.WriteLine($"La temperatura en grados Fahrenheit es: {celsiusFahrenheit()}");
                break;
            case 2:
                Console.WriteLine($"La temperatura en grados Celsius es: {fahrenheitCelsius()}");
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
        break;

    case 6: //Contador de Vocales
        Console.WriteLine("Contador de Vocales seleccionada");
        cadena = string.Empty; // Inicializar la variable 'cadena'
        Console.WriteLine($"El número de vocales en la cadena de texto ingresada es: {contarVocales(cadena)}");
        break;

    case 7: //Cálculo de Factorial
        Console.WriteLine("Cálculo de Factorial seleccionada");
        Console.WriteLine("Ingrese un número entero: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"El factorial de {n} es: {factorial(n)}");
        break;

    case 8: //Juego de Adivinanza
        Console.WriteLine("Juego de Adivinanza seleccionada");
        Random random = new Random();
        int intento, numeroAleatorio = random.Next(1, 101);
        do{
            Console.WriteLine("Adivine el número (entre 1 y 100): ");
            intento = int.Parse(Console.ReadLine());
            if (intento < numeroAleatorio){
                Console.WriteLine("Demasiado bajo");
            }
            else if (intento > numeroAleatorio){
                Console.WriteLine("Demasiado alto");
            }
        } while (intento != numeroAleatorio);
        Console.WriteLine("¡Felicidades! Adivinaste el número.");
        break;

    case 9: //Paso por Referencia
        Console.WriteLine("Paso por Referencia seleccionada");
        Console.WriteLine("Ingrese el primer número: ");
        while (!int.TryParse(Console.ReadLine(), out num1)){
            Console.WriteLine("Entrada no válida. Ingrese un número entero: ");}
        Console.WriteLine("Ingrese el segundo número: ");
        while (!int.TryParse(Console.ReadLine(), out num2)){
            Console.WriteLine("Entrada no válida. Ingrese un número entero: ");}

        Console.WriteLine($"Valores originales: num1 = {num1}, num2 = {num2}");
        Intercambiar(ref num1, ref num2);
        Console.WriteLine($"Valores intercambiados: num1 = {num1}, num2 = {num2}");
        break;

    case 10: //Tabla de Multiplicar
        Console.WriteLine("Tabla de Multiplicar seleccionada");
        Console.WriteLine("Ingrese un número entero: ");
        numero = int.Parse(Console.ReadLine());
        TablaMultiplicar(numero);
        break;

    default:
        Console.WriteLine("Opción no válida");
        break;
}
