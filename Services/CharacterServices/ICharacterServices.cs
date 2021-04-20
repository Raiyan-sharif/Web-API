using System.Collections.Generic;
using System.Threading.Tasks;
using Web_API.Models;

namespace Web_API.Services.CharacterServices
{
    public interface ICharacterService
    {
        Task<List<Character>> GetAllCharacter();
        Task<Character> GetCharacterById(int id);
        Task<List<Character>> AddCharacter(Character newCharacter);
        
    }
}