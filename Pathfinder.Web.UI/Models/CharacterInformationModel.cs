using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Pathfinder.Generators.Background;

namespace Pathfinder.Web.UI.Models
{
    public class CharacterInformationModel
    {
        public CharacterInformation Information { get; set; }

        public CharacterInformationModel(CharacterInformation information)
        {
            this.Information = information;
        }

        public IEnumerable<SelectListItem> TraitsList
        {
            get
            {
                List<ListItem> items = new List<ListItem>();
                foreach (ITrait trait in Information.Traits)
                {
                    items.Add(new ListItem(trait.Title));
                }
                return new SelectList(items);
            }
        }

        public IEnumerable<SelectListItem> StoryFeatsList
        {
            get
            {
                List<ListItem> items = new List<ListItem>();
                foreach (IStoryFeats feat in Information.StoryFeats)
                {
                    items.Add(new ListItem(feat.Title));
                }
                return new SelectList(items);
            }
        }
    }
}