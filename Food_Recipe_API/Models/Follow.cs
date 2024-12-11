using System.ComponentModel.DataAnnotations.Schema;

namespace Food_Recipe_API.Models
{
    [Table("Followings")]
    public class Follow: BaseModel
    {
        public Guid FollowerId { get; set; }  // User who is following
        public Guid FollowedUserId { get; set; } // User who is being followed
        public virtual User Follower { get; set; }
        public virtual User FollowedUser { get; set; }
    }
}   