using System.ComponentModel.DataAnnotations.Schema;

namespace Food_Recipe_API.Models
{
    [Table("Followings")]
    public class Following: BaseModel
    {
        public Guid FollowerId { get; set; }
        public Guid FollowedUserId { get; set; }
        public virtual User Follower { get; set; }
        public virtual User FollowerUser { get; set; }
    }
}