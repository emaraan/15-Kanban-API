//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kanban_API
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class Card
    {
        public Card()
        {
            this.CardId = CardId;
            this.CreatedDate = CreatedDate;
            this.ListId = ListId;
            this.Text = Text;
        }

        public Card(CardModel model)
        {
            this.Update(model);
            CreatedDate = DateTime.Now;
        }

        public int CardId { get; set; }
        public int ListId { get; set; }
        public System.DateTime CreatedDate { get; set; }

        [Required]
        public string Text { get; set; }
    
        public virtual List List { get; set; }

        public void Update(CardModel model)
        {
            Text = model.Text;
        }
    }
}
