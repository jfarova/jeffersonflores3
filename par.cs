class par:numero{
    private int numero1{get;set;}
    public par (int numero1):base(numero1){
        this.numero1=numero1;
        if(numero1 % 2 == 0){
            Console.WriteLine("el numero es par :"+numero1);
        }
        else{
            Console.WriteLine("el numero es impar :"+numero1);
            


        }

}
}