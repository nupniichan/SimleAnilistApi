﻿using AnilistAPI;

class Program
{
    static async Task Main(string[] args)
    {
        // Test if my code can get my anilist profile
        await CharacterSearch.SearchCharacter("chino kafuu");
    }
}
