﻿using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NoteTaker
{
    public class NotesManager
    {
        private List<NoteEntry> notes;
        public NotesManager(string filepath)
        {
            notes = new List<NoteEntry>();
            LoadNotesFromFile(filepath);
        }
        public void AddNote(string noteName, DateTime date, string input, Font font, Color color, int size)
        {
            NoteEntry note = new NoteEntry(noteName, date, input, font, color, size);
            notes.Add(note);
        }
        public void RemoveNote(int noteId)
        {
            notes.Find(o => o.Id == noteId).IsDeleted = true;
        }
        public void EditNote(int noteId, string newName, string newText, Font font, Color color, int size)
        {
            notes.Find(o => o.Id == noteId).Name = newName;
            notes.Find(o => o.Id == noteId).Text = newText;
            notes.Find(o => o.Id == noteId).Color = color;
            notes.Find(o => o.Id == noteId).Font = font;
            notes.Find(o => o.Id == noteId).Size = size;
        }
        public List<NoteEntry> GetAllNotes()
        {
            return notes;
        }
        public List<NoteEntry> SearchNotes(string content)
        {
            List<NoteEntry> machingNotes = notes.FindAll(obj => obj.Name.IndexOf(content, StringComparison.OrdinalIgnoreCase) >= 0 || obj.Text.IndexOf(content, StringComparison.OrdinalIgnoreCase) >= 0);
            return machingNotes;
        }
        public void SaveNotesToFile(string filePath)
        {
            string json = JsonConvert.SerializeObject(notes);
            File.WriteAllText(filePath, json);
        }
        public void LoadNotesFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                notes = JsonConvert.DeserializeObject<List<NoteEntry>>(json);
            }
        }
    }
}