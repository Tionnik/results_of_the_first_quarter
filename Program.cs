string [] Recognition(string text){
    string[] array = text.Split(new char [] {' '});
    return array;
}
string [] Scan(string []words, int n){
    int j =0;
    int [] arr = new int [words.Length];
    for (int i=0; i<words.Length; i++){
        if(words[i].Length < n+1 ){
            arr[j]= i;
            j++;
        }
    }
    string [] result = new string [j];
    for (j=0; j<result.Length; j++){
        result[j]=words[arr[j]];
    } 
return result;
}

Console.Clear();
Console.WriteLine("Введите текст для распознания");
string text = Console.ReadLine()!;
Console.WriteLine("Введите кол-во элементов для распознания");
int n = int.Parse(Console.ReadLine()!);
string [] words=Scan(Recognition(text),n);
Console.WriteLine();
Console.WriteLine($"[{string.Join(", ", words)}]");
