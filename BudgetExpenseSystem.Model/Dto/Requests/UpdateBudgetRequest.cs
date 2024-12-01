namespace BudgetExpenseSystem.Model.Dto.Requests;

public class UpdateBudgetRequest
{
	public int CategoryId { get; set; }

	public int BudgetTypeId { get; set; }

	public decimal Amount { get; set; }
}
