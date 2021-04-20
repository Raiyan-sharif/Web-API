using System.Collections.Generic;
using System.Threading.Tasks;
using Web_API.Models;

namespace Web_API.Services.CharacterServices
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<Character>>> GetAllCharacter();
        Task<ServiceResponse<Character>> GetCharacterById(int id);
        Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
        
    }
}