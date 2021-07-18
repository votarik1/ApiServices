using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW1
{
    public class WeatherForecast
    {
        public List<Note> Notes { get; set; }
        public WeatherForecast()
        {
            Notes = new List<Note>();
        }

        public void AddNewNote(int t)
        {
            Note NewNote = new Note(DateTime.Now, t);
            Notes.Add(NewNote);
        }

        public string ReadNotes(DateTime FromDate, DateTime TillDate)
        {
            StringBuilder ForReturn = new StringBuilder();
            foreach (var item in Notes)
            {
                if (item.Date >= FromDate&& item.Date<= TillDate)
                {
                    ForReturn.Append($"\n {item.Date} {item.Temperature}C");
                }
            }
            return ForReturn.ToString();
        }

        public void UpdateNote(DateTime date, int t)
        {
            foreach (var item in Notes)
            {
                if (item.Date == date)
                {
                    item.Temperature = t;
                }
            }
        }

        public void Delete(DateTime date)
        {
            Notes = Notes.Where(w => w.Date != date).ToList();
        }

    }
}
