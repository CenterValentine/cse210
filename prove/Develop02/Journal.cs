using System;
using System.ComponentModel.Design;
using System.IO;
using System.Net.Http;


public class Journal()
{
    public string _filename;
    public List<Entry> _Entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _Entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry E in _Entries)
        {
            E.displayEntry();
        }
    }

    public void saveEntries(string fileName, List<Entry> entries)
    {
        foreach (Entry entry in entries)
        {

            using (StreamWriter outputFile = new StreamWriter(fileName, true))
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._entry}");
            }
        }
    }

// Sync with Airtable Journal
// private static string _api_key = Console.ReadLine();
// private string atJournalTableId = "tblQTEVTCXTXJ7xvj";
// private string atDateId = "fld6Z1a4BIfeFVFre";
// private string atPromptId = "fldZMloEqwRc8GMNQ";
// private string atEntryId = "fldDLXDiPuJkXsEWY";



// pat7dlYOAmzYQ1mea.3822448956dc1013fe47b31c7dd08195c2222ae43325141c61b6a1497cf98d70


    public void loadEntries(string filename)
    {
        string[] entries = System.IO.File.ReadAllLines(filename);
        foreach (string entry in entries)
        {
            string[] parts = entry.Split("|");
            Entry entryNew = new Entry();
            // Console.WriteLine($"Loading {parts[0]},{parts[1]},{parts[2]}");
            entryNew._date = parts[0];
            entryNew._prompt = parts[1];
            entryNew._entry = parts[2];
            AddEntry(entryNew);
        }
    }
    //  public async Task FetchJournalEntries()
    // {
    //     using (HttpClient client = new HttpClient())
    //     {
    //         try
    //         {
    //             Console.Write("Enter your Airtable API key: ");
    //             // string _api_key = Console.ReadLine(); // Read API key from user input
    //             string apiUrl = "https://api.airtable.com/v0/appSU1MCHOTx9350A/Journal?maxRecords=100";
    //             client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_api_key}");
    //             HttpResponseMessage response = await client.GetAsync(apiUrl);
    //             response.EnsureSuccessStatusCode();
    //             string responseBody = await response.Content.ReadAsStringAsync();
    //             Console.WriteLine(responseBody);
    //         }
    //         catch (HttpRequestException e)
    //         {
    //             Console.WriteLine("\nException Caught!");
    //             Console.WriteLine("Message :{0} ", e.Message);
    //         }
    //     }
    // }
}

