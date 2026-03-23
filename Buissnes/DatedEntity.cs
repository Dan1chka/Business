namespace Buissnes;
using System;
public class Date
{
    
    public DateTime Date { get; protected set; } = DateTime.Now;

    // Защищенный метод для установки даты (только из наследников)
    protected void SetDate(DateTime date)
    {
        if (date > DateTime.Now)
            throw new ArgumentException("Дата не может быть в будущем.");
        Date = date;
    }

    public override string ToString() => Date.ToString("dd.MM.yyyy HH:mm");
}
