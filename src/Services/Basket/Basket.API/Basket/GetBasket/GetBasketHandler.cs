﻿namespace Basket.API.Basket.GetBasket
{
    public record GetBasketQuery(string Username) : IQuery<GetBasketResult>;
    public record GetBasketResult(ShoppingCart Cart);

    public class GetBasketQueryHandler : IQueryHandler<GetBasketQuery, GetBasketResult>
    {
        public async Task<GetBasketResult> Handle(GetBasketQuery query, CancellationToken cancellationToken)
        {
            // Todo: Implement the logic to get the basket from the database
            //var basket = await _repository.GetBasketAsync(query.Username);

            return new GetBasketResult(new ShoppingCart("swn"));
        }
    }
}
