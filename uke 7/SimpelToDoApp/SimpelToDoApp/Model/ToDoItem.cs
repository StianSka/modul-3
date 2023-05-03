namespace SimpelToDoApp.Model
{
    public class ToDoItem
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public DateTime? Done { get; set; }

        public ToDoItem(string text) : this()
        {
            Text = text;
        }

        public ToDoItem() 
        { 
            Id = Guid.NewGuid();
        }
    }
}
