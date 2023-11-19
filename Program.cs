namespace tiendavirtual
{
    class Program
{
    private static void Main(string[] args)
    {
        string[,] products_list = new string[6,3];/*primero filas y luego columnas*/
        int items;//cantidad de cosas a comprar
        int code;//codigo del elemento
        int quantity;//cantidad a comprar
        int suma;//suma el costo en el bucle
        int total;// coste total
        
        products_list[0,0]="arroz";
        products_list[0,1]="200";
        products_list[0,2]="0";

        products_list[1,0]="azucar";
        products_list[1,1]="180";
        products_list[1,2]="1";

        products_list[2,0]="frijol";
        products_list[2,1]="350";
        products_list[2,2]="2";

        products_list[3,0]="sal";
        products_list[3,1]="100";
        products_list[3,2]="3";

        products_list[4,0]="aceite";
        products_list[4,1]="450";
        products_list[4,2]="4";

        products_list[5,0]="miel";
        products_list[5,1]="270";
        products_list[5,2]="5";

        for(int i = 0;i<6;i++){
            Console.WriteLine(products_list[i,0]+products_list[i,1]+products_list[i,2]);
        }

        Console.WriteLine("escriba cantidad de elementos que va a comprar");
        items = int.Parse(Console.ReadLine());

        for(int i=0;i<=items;i++){
           Console.WriteLine("Escriba el codigo del producto y la cantidad que va a comprar");
           code = int.Parse(Console.ReadLine());
           if(code > products_list.Length){
            Console.WriteLine("ingrese un codigo valido");
            i--;
           }
           else{
            quantity = int.Parse(Console.ReadLine());
            suma = int.Parse(products_list[code,1])*quantity;
            total += suma;
           }
        }
        Console.WriteLine(total);

    }
}
}