using System.Collections.Generic;
using Web_API.Models;

namespace Web_API.Services.CharacterServices
{
    public interface ICharacterService
    {
        List<Character> GetAllCharacter();
        Character GetCharacterById(int id);
        List<Character> AddCharacter(Character newCharacter);
        
    }
}