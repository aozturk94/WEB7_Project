using Microsoft.EntityFrameworkCore;
using MiniShopApp.Data.Abstract;
using MiniShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Concrete.EfCore
{
    public class EfCoreCardRepository : EfCoreGenericRepository<Card, MiniShopContext>, ICardRepository
    {
        public void DeleteCartLog(int cartId)
        {
            using (var context = new MiniShopContext())
            {
                var cmd = @"DELETE FROM CardItems WHERE CardId = @p0";
                context.Database.ExecuteSqlRaw(cmd, cartId);
            }
        }

        public void DeleteFromCart(int cartId, int productId)
        {
            using (var context = new MiniShopContext())
            {
                var cmd = @"DELETE FROM CardItems WHERE CardId = @p0 AND ProductId = @p1";
                context.Database.ExecuteSqlRaw(cmd, cartId, productId);
            }
        }

        public Card GetByUserId(string userId)
        {
            using (var context = new MiniShopContext())
            {
                return context.Cards
                    .Include(i => i.CardItems)
                    .ThenInclude(i => i.Product)
                    .FirstOrDefault(i => i.UserId == userId);
            }
        }

        public override void Update(Card entity)
        {
            using (var context = new MiniShopContext())
            {
                context.Cards.Update(entity);
                context.SaveChanges();
            }
            base.Update(entity);
        }
    }
}
