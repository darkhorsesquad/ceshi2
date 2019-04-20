//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.Folders = new HashSet<Folder>();
            this.Friends = new HashSet<Friend>();
            this.Friend_Conversation = new HashSet<Friend_Conversation>();
            this.Friend_Conversation1 = new HashSet<Friend_Conversation>();
            this.Groups = new HashSet<Group>();
            this.Group_Conversation = new HashSet<Group_Conversation>();
            this.Group_personnel = new HashSet<Group_personnel>();
            this.Personal_data = new HashSet<Personal_data>();
            this.Share_data = new HashSet<Share_data>();
            this.Skins = new HashSet<Skin>();
            this.Store_data = new HashSet<Store_data>();
        }
    
        public int User_ID { get; set; }
        public string User_Name { get; set; }
        public string User_Password { get; set; }
        public string User_Phone { get; set; }
        public string User_Two_Password { get; set; }
        public int FriendNews { get; set; }
        public int JoinGroup { get; set; }
        public string Head_portrait { get; set; }
        public System.DateTime RegisterTime { get; set; }
        public string Skin_Style { get; set; }
    
        public virtual ICollection<Folder> Folders { get; set; }
        public virtual ICollection<Friend> Friends { get; set; }
        public virtual ICollection<Friend_Conversation> Friend_Conversation { get; set; }
        public virtual ICollection<Friend_Conversation> Friend_Conversation1 { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Group_Conversation> Group_Conversation { get; set; }
        public virtual ICollection<Group_personnel> Group_personnel { get; set; }
        public virtual ICollection<Personal_data> Personal_data { get; set; }
        public virtual ICollection<Share_data> Share_data { get; set; }
        public virtual ICollection<Skin> Skins { get; set; }
        public virtual ICollection<Store_data> Store_data { get; set; }
    }
}
