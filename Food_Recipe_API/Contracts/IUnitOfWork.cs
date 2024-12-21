﻿using Food_Recipe_API.Models;

namespace RECIPE_MANAGEMENT_SYSTEM.Contracts
{
    public interface IUnitOfWork: IDisposable
    {
        IUserRepository Users { get; }
        IRecipeRepository Recipes { get; }
        IRatingRepository Ratings { get;  }
        INotificationRepository Notifications { get;  }
        IFollowRepository Follows { get;  }
        IFavoriteRepository Favorites { get;  }
        ICommentRepository Comments { get;  }
        ICategoryRepository Categories { get;  }

        Task CommitAndSaveAsync();
    }
}