/* Matriz Aleatoria
Se requiere: 
Crear una función llamada RandomArray() que devuelva una matriz de enteros​
    Crea una matriz vacía que contenga 10 valores enteros.​
    Recorre la matriz y asigna a cada índice un valor entero aleatorio entre 5 y 25.​
    Imprime los valores mínimo y máximo de la matriz.​
    Imprime la suma de todos los valores.​ */
static int[] RandomArray(){
    int[] array = new int[10];
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++){
        array[i] = rnd.Next(5, 26);
    }
    int min = array[0];
    int max = array[0];
    int sum = 0;
    foreach(int num in array){
        if(num < min){
            min = num;
        }
        if(num > max){
            max = num;
        }
        sum += num;
    }
    Console.WriteLine($"El valor minimo del array es: {min} y el maximo es: {max}");
    Console.WriteLine($"La suma de todos los valores es: {sum}");
    return array;
}
/* Lanzamiento de Moneda
Se requiere: 
Crear una función llamada TossCoin() que devuelva una cadena. ​
    Que la función imprima "¡Tirando una moneda!".​
    Lanzar una moneda al azar con un resultado que señale cualquiera de las dos caras de la moneda. ​
    Haz que la función imprima "Cara" o "Cruz".​
    Por último, devuelve el resultado.

Opcional:
Crea otra función llamada TossMultipleCoins(int num) que devuelva un Doble. ​
    Haz que la función llame a la función tossCoin varias veces en función del valor num.​
    Haz que la función devuelva un Doble que refleje la relación entre el lanzamiento de cabezas y el lanzamiento total.​ */
static string TossCoin(){
    Console.WriteLine("¡Tirando una moneda!");
    Dictionary<int, string> moneda = new Dictionary<int, string>();
    moneda.Add(0, "Cara");
    moneda.Add(1, "Cruz");
    Random rnd = new Random();
    int num = rnd.Next(0, 2);
    Console.WriteLine(moneda[num]);
    return moneda[num];
}
static double TossMultipleCoins(int num){
    int cara = 0;
    for(int i = 0; i < num; i++){
        if(TossCoin() == "Cara"){
            cara++;
        }
    }
    double porcentaje = cara / num;
    return porcentaje;
}
/* Nombres
Construye una función Nombres que devuelva una lista de cadenas. En esta función:​
Se requiere: 
    Crea una lista con los valores Todd, Tiffany, Charlie, Ginebra, Sydney. ​
    Devuelve una lista que solo incluya nombres de más de 5 caracteres. ​
Opcional:
    Baraja la lista e imprime los valores en el nuevo orden. ​ */
static List<string> Nombres()
{
    List<string> nombres = new List<string>();
    nombres.Add("Todd");
    nombres.Add("Tiffany");
    nombres.Add("Charlie");
    nombres.Add("Ginebra");
    nombres.Add("Sydney");
    List<string> nombres_5car = new List<string>();
    foreach(string nombre in nombres){
        if(nombre.Length > 5){
            nombres_5car.Add(nombre);
        }
    }
    nombres_5car.Sort();
    foreach(string nombre in nombres_5car){
        Console.WriteLine(nombre);
    }
    return nombres_5car;
}