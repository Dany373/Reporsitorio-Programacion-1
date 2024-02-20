
//SEMANA 3

//EVITAR ERRORES DEL USUARIO CON TRY CATCH

//1. Calcular el mayor de tres numeros 

using System.Linq.Expressions;
using System.Runtime.InteropServices;

try
{

    Console.WriteLine("Ingrese el primer numero: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo numero: ");
    int num2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el tercer numero: ");
    int num3 = int.Parse(Console.ReadLine());
    int mayor = Math.Max(Math.Max(num1, num2), num3);
    Console.WriteLine("El mayor de los tres numeros es: " + mayor);

}
catch (FormatException error)
{
    Console.WriteLine("Error: Haz ingresado un valor no valido. Introduce un numero entero");
}
catch (ArgumentNullException vacio)
{
    Console.WriteLine("ERROR: El argumento no puede estar vacio" + vacio.Message);
}


// 2. Validar Edad Para Ingresar a un Club

try
{
    Console.WriteLine("Introduce tu edad");
    int edad = int.Parse(Console.ReadLine());

    if (edad >= 18)
    {
        Console.WriteLine("Binvenido al Club Malibu");
    }
    else
    {
        Console.WriteLine("Acceso denegado.");
    }
}
catch (Exception not)
{
    Console.WriteLine("Introduce un numero entero");
}



//3. Calcular el Precio Final de un Producto 

try
{
    Console.WriteLine("Ingrese el precio original del producto: ");
    double precioOriginal = double.Parse(Console.ReadLine());
    double descuento = 0;
    if (precioOriginal > 100)
    {
        descuento = precioOriginal * 0.10;
    }
    double precioFinal = precioOriginal - descuento;
    Console.WriteLine("El precio final del producto es de Q:" + precioFinal);
}
catch (FormatException d)
{
    Console.WriteLine("ERROR: Se ha introducido un valor no valido" + d.Message);
}
catch (ArgumentNullException nulo)
{
    Console.WriteLine("ERROR: El argumento no puede estar vacio" + nulo.Message);
}


// 4. Validar usuario y contraseña 

string usercorrecto = "usuario";
string contraseñacorrecta = "contraseña";

bool valido = false;
int numintentos = 0;

do
{
    numintentos++;

    try
    {
        Console.WriteLine("Introduzca su nombre de usuario:");
        usercorrecto = Console.ReadLine();
        if (string.IsNullOrEmpty(usercorrecto))
        {
            throw new ArgumentNullException("usuario", "No puede ser vacio");
        }

        Console.WriteLine("Introduzca su contraseña:");
        contraseñacorrecta = Console.ReadLine();
        if (string.IsNullOrEmpty(contraseñacorrecta))
        {
            throw new ArgumentNullException("contraseña", "No puede ser vacio");
        }

        if ("usuario" == usercorrecto && "contraseña" == contraseñacorrecta)
        {
            valido = true;
            Console.WriteLine("Acceso permitido");
        }
        else
        {
            Console.WriteLine("Acceso denegado");
        }
    }
    catch (FormatException denegade)
    {
        Console.WriteLine("Se ha introducido un valor no valido" + denegade.Message);
    }
    catch (ArgumentNullException invalido)
    {
        Console.WriteLine("Vacio o nulo" + invalido.Message);
    }

}
while (!valido && numintentos < 3);

//5. Determinar si un numero es par o impar

try
{
    Console.WriteLine("Ingrese un numero:");
    int num = int.Parse(Console.ReadLine());
    int par = num / 2;
    if (num % 2 == 0)
    {
        Console.WriteLine("El numero " + num + " es par");

    }
    else
    {
        Console.WriteLine("El numero " + num + " es impar");
    }
}
catch (Exception)
{
    Console.WriteLine("ERROR: Ingrese un numero entero ");
}


// 6.Mostrar Un Mensaje de Aprobacion o Rechazo de Prestamo

try
{
    Console.WriteLine("Ingrese el monto de prestamo que desea solicitar");
    double monto = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese su edad");
    int edad = int.Parse(Console.ReadLine());

    if (monto < 5000 || edad > 60)
    {
        Console.WriteLine("Su Prestamo Fue Aprobado");
    }
    else
    {
        Console.WriteLine("El Prestamo Fue Rechazado");
    }
}
catch (Exception)
{
    Console.WriteLine("ERROR: Ingreso un dato invalido");
}


// 7. Calcular el Área de una Figura Geométrica

try
{
    Console.WriteLine("Introduzca el tipo de figura Geometrica (triangulo, cuadrado o circulo): ");
    string figura = Console.ReadLine().ToLower();

    double dimension1 = 0, dimension2 = 0;

    switch (figura)
    {
        case "triángulo":
            Console.WriteLine("Introdzca la base del triangulo");
            dimension1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca la altura del triangulo:");
            dimension2 = double.Parse(Console.ReadLine());
            break;

        case "cuadrado":
            Console.WriteLine("Introduzca un lado del cuadrado");
            dimension2 = double.Parse(Console.ReadLine());
            break;

        case "circulo":
            Console.WriteLine("Introduzca el radio del circulo");
            dimension1 = double.Parse(Console.ReadLine());
            break;
        default:
            throw new ArgumentException("Figura geometrica no valida");

    }
    double area = 0;
    switch (figura)
    {
        case "triangulo":
            area = (dimension2 * dimension2) / 2;
            break;

        case "cuadrado":
            area = dimension1 * dimension1;
            break;
        case "circulo":
            area = Math.PI * Math.Pow(dimension1, dimension2);
            break;
            Console.WriteLine("El área de la {0} es: {1}", figura, area.ToString("F2"));
    }

}
catch (FormatException)
{
    Console.WriteLine("ERROR: Se ha introducido un valor no valido");
}
catch (ArgumentException)
{
    Console.WriteLine("ERROR: Se ha introducido una figura no valida");
}




//EJERCICIOS USANDO SWITCH

//1. Convertir un numero de letra a numero

Console.WriteLine("Introduzca un numero del 1 al 5 en letra (uno, dos, tres, cuatro, cinco:");
string numeroAletra = Console.ReadLine().ToLower();

int numero = 0;
bool correcto = true;

switch (numeroAletra)
{
    case "uno":
        numero = 1;
        break;
    case "dos":
        numero = 2;
        break;
    case "tres":
        numero = 3;
        break;
    case "cuatro":
        numero = 4;
        break;
    case "cinco":
        numero = 5;
        break;
    default:
        correcto = false;
        break;

}
if (correcto)
{
    Console.WriteLine("El numero en digito es:" + numero);
}
else
{
    Console.WriteLine("El numero introducio no es valido");
}


//2.Mostrar el dia de la semana a partir de un numero 

Console.WriteLine("Introduzca un numero del 1 al 7 para saber que dia de la semana es: ");
int numerodia = int.Parse(Console.ReadLine());

string diasem = "";
bool acierto = true;

switch (numerodia)
{
    case 1:
        diasem = "Lunes";
        break;
    case 2:
        diasem = "Martes";
        break;
    case 3:
        diasem = "Miercoles";
        break;
    case 4:
        diasem = "Jueves";
        break;
    case 5:
        diasem = "Viernes";
        break;
    case 6:
        diasem = "Sabado";
        break;
    case 7:
        diasem = "Domingo";
        break;
    default:
        acierto = false;

        break;

}
if (acierto)
{
    Console.WriteLine("El dia de la semana es:" + diasem);
}
else
{
    Console.WriteLine("El numero introducio no es valido");
}


//3. Calcular el importe a pagar por un servicio

Console.WriteLine("Introsuzca el tipo de servicio: lavado de auto, cambio de aceite, revision mecanica");
string servicio = Console.ReadLine();

string tiposerv = "";
bool disponible = true;

switch (servicio)
{
    case "lavado de auto":
        tiposerv = "Q50";
        break;
    case "cambio de aceite":
        tiposerv = "Q100";
        break;
    case "revision mecanica":
        tiposerv = "Q200";
        break;
    default:
        disponible = false;
        break;
}

if (disponible)
{
    Console.WriteLine("El importe a pagar por ese servicio es de: " + tiposerv);
}
else
{
    Console.WriteLine("El servicio solicitado no esta disponible");
}




//4. Mostrar un Mensaje de Bienvenida en Diferentes Idiomas

Console.WriteLine("Introduzca su idioma de preferencia: Español, Frances o Ingles");
string idioma = Console.ReadLine().ToLower();

string mensaje = "";
bool equivale = true;

switch (idioma)
{
    case "español":
        mensaje = "¿Bienvenido, en que podemos ayudarte hoy?";
        break;
    case "ingles":
        mensaje = "Welcome, how can we help you?";
        break;
    case "frances":
        mensaje = "Bienvenue, comment pouvons-nous vous aider ?";
        break;
    default:
        equivale = false;
        break;

}
if (equivale)
{
    Console.WriteLine(mensaje);
}
else
{
    Console.WriteLine("Idioma no disponible");
}



//5. Evaluar la Calificacion de un Examen


const int MIN_CALIFICACION = 0;
const int MAX_CALIFICACION = 100;
const int SOBRESALIENTE_MIN = 90;
const int NOTABLE_MIN = 80;
const int APROBATORIA_MIN = 70;
const int NO_APROBATORIA_MIN = 60;

string texto;

Console.WriteLine("Introduzca la calificación del examen (0-100):");
int calificacion = int.Parse(Console.ReadLine());

try
{

    if (calificacion < MIN_CALIFICACION || calificacion > MAX_CALIFICACION)
    {
        throw new ArgumentOutOfRangeException("La calificación debe estar entre 0 y 100.");
    }

    switch (calificacion)
    {
        case int n when n >= SOBRESALIENTE_MIN && n <= MAX_CALIFICACION:
            texto = "Sobresaliente";
            break;
        case int n when n >= NOTABLE_MIN && n < SOBRESALIENTE_MIN:
            texto = "Notable";
            break;
        case int n when n >= APROBATORIA_MIN && n < NOTABLE_MIN:
            texto = "Aprobatoria";
            break;
        case int n when n >= NO_APROBATORIA_MIN && n < APROBATORIA_MIN:
            texto = "No aprobatoria";
            break;
        default:
            texto = "Reprobado";
            break;
    }

    Console.WriteLine("Su desempeño es: {0}", texto);
}
catch (FormatException)
{
    Console.WriteLine("Error: El valor ingresado no es un número válido.");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine("Error: {0}", ex.Message);
}
