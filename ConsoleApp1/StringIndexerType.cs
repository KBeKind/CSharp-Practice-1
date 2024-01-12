
internal class StringIndexerType{

    private string[] strArray = new string[10];

    public string this[int index]{
        get {
            if (index < 0 || index >= strArray.Length){
                throw new IndexOutOfRangeException("Index out of range");
                }
            return strArray[index];
        }
        set {
            if (index < 0 || index >= strArray.Length){
                throw new IndexOutOfRangeException("Index out of range");
                }
            strArray[index] = value;
        }
    }

}