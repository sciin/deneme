public class DialogAdd
{
    private string text;
    private int id;
    private int dialogID;

    public DialogAdd(string text, int id, int dialogID)
    {
        this.text = text;
        this.id = id;
        this.dialogID = dialogID;
    }
    public string Text
    {
        get
        {
            return text;
        }
        set
        {
            text = value;
        }
    }
    public int Id
    {
        get
        {
            return id;
        }
        set
        {
            id = value;         
        }
    }
    public int DialogID
    {
        set
        {
            dialogID = value;
        }
        get
        {
            return dialogID;
        }
    }
}