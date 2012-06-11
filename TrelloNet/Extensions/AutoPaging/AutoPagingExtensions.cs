namespace TrelloNet.Extensions
{
	public static class AutoPagingExtensions
	{
		public static AutoPaged AutoPaged(this IActions trelloActions, int pageSize = 50)
		{
			return new AutoPaged(trelloActions, pageSize);
		}
	}
}