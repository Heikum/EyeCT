using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public class Reaction
    {
        private int id;
        private string text;
        private int reactionId;
        private DateTime reactionDateTime;
        private int accountId;
        private int postId;
        private Student postedByStudent;
        private Admin postedByAdmin;

        public Reaction(int id, string text, int reactionId, DateTime reactionDateTime, int accountId, int postId)
        {
            this.id = id;
            this.text = text;
            this.reactionId = reactionId;
            this.reactionDateTime = reactionDateTime;
            this.accountId = accountId;
            this.postId = postId;
        }

        public Reaction(string text, int reactionId, DateTime reactionDateTime, int accountId, int postId)
        {
            this.text = text;
            this.reactionId = reactionId;
            this.reactionDateTime = reactionDateTime;
            this.accountId = accountId;
            this.postId = postId;
        }

        public Reaction(int postId, string text, DateTime reactionDateTime)
        {
            this.postId = postId;
            this.text = text;
            this.reactionDateTime = reactionDateTime;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
            }
        }

        public int ReactionId
        {
            get
            {
                return reactionId;
            }

            set
            {
                reactionId = value;
            }
        }

        public DateTime ReactionDateTime
        {
            get
            {
                return reactionDateTime;
            }

            set
            {
                reactionDateTime = value;
            }
        }

        public int AccountId
        {
            get
            {
                return accountId;
            }

            set
            {
                accountId = value;
            }
        }

        public int PostId
        {
            get
            {
                return postId;
            }

            set
            {
                postId = value;
            }
        }

        public bool AddStudent(Student student)
        {
            if (this.postedByStudent == null)
            {
                this.postedByStudent = student;
                return true;
            }
            return false;
        }

        public bool AddAdmin(Admin admin)
        {
            if (this.postedByAdmin == null)
            {
                this.postedByAdmin = admin;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return postedByStudent + "" + postedByAdmin + text + " geplaatst op: " + reactionDateTime;
        }
    }
}
