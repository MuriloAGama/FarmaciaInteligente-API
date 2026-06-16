namespace FarmaciaInteligenteAPI.src.Services;

public class MedicamentoService : IMedicamentoService
{
    public string ObterSugestao(string sintoma)
    {
        return $"Sugestão para {sintoma}: Paracetamol (Exemplo)";
    }
}