using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vilta_Database_Access.Snippets;
using Vilta_Logic;
using Vilta_Logic.Snippets;
using Vilta_Snippet.Controls;
using Vilta_Snippet.General_Forms;

namespace Vilta_Snippet
{
    public partial class frmChoseTags : Form
    {
        private bool _NormalMode = false;

        public frmChoseTags(bool IsNormalMode = false)
        {
            InitializeComponent();
            _NormalMode = IsNormalMode;
        }

        private void _ShowEmptyMessage()
        {
            ctrlEmptyMessage Message = new ctrlEmptyMessage();

            //Set Colors
            Message.BackColor               = Color.FromArgb(250, 250, 250);
            Message.EmptyMegImg.BackColor   = Color.FromArgb(250, 250, 250);
            Message.txtMainText.BackColor   = Color.FromArgb(250, 250, 250);
            Message.txtSecondText.BackColor = Color.FromArgb(250, 250, 250);

            //Set Values
            Message.EmptyMegImg.Load(@"D:\Vilta Snippet\Images\Icons\UnChecked Icons\Tag.png");
            Message.txtMainText.Text = "There's No Tags !";
            Message.txtSecondText.Text = "To deal with tags, add a new tag...";
            Message.Show();

            TagsContainer.Controls.Add(Message);
            TagsContainer.Padding = new System.Windows.Forms.Padding(170, 20, 0, 0);
        }

        private void _SetSnippetsCount(ref ctrlTag_Shape2 SelectedTag, clsTags Tags, ref int Counter, string Tag)
        {
            if (Tags.TagSnippets.Rows.Count > Counter)
            {
                if ((string)Tags.TagSnippets.Rows[Counter]["TagName"] == Tag)
                {
                    SelectedTag = new ctrlTag_Shape2(Tag, (int)Tags.TagSnippets.Rows[Counter]["Snippets"], _NormalMode);
                    Counter++;
                }
            }
        }

        private void _SetTagEvents(ref ctrlTag_Shape2 SelectedTag, string Tag, string SelectedTagName)
        {
            SelectedTag.SelecteEvent += Un_SelectTag;
            SelectedTag.TagUpdated += _RefreshTags;
            SelectedTag.btnSelect.Checked = (Tag == SelectedTagName);
        }

        private void _SetTagsLogic(clsTags Tags)
        {
            string SelectedTagName = "";
            int Counter = 0;

            foreach (string Tag in Tags.TagsNames)
            {
                //Get Prev Selected Tags
                if (clsTags.SelectedTagsNames.Count > 0)
                    SelectedTagName = clsTags.SelectedTagsNames.Find(item => item.Contains(Tag));

                ctrlTag_Shape2 SelectedTag = new ctrlTag_Shape2(Tag, 0, _NormalMode);

                _SetSnippetsCount(ref SelectedTag, Tags, ref Counter, Tag);
                _SetTagEvents(ref SelectedTag, Tag, SelectedTagName);

                TagsContainer.Controls.Add(SelectedTag);
            }
        }

        private void _LoadTags(string Search = "")
        {
            TagsContainer.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            clsTags Tags   = new clsTags();
            Tags.TagsNames = clsTags.LoadTags();

            //Search Filter
            if (Search != "")
            {
                if(clsUserSettings.Settings.CaseSensitive)
                    Tags.TagsNames = Tags.TagsNames.FindAll(item => item.Contains(Search));
                else
                    Tags.TagsNames = Tags.TagsNames.FindAll(item => item.ToLower().Contains(Search.ToLower()));
            }

            Tags.TagSnippets = clsTags.GetTagsSnippets(Tags.TagsNames);

            if (Tags.TagsNames.Count > 0)
                _SetTagsLogic(Tags);
            else
                _ShowEmptyMessage();
        }

        private void Un_SelectTag(string TagName, bool SelectedState)
        {
            int TagID = clsTags.Find(TagName);

            if (SelectedState)
            {
                clsTags.SelectedTagsIDs.Add(TagID);
                clsTags.SelectedTagsNames.Add(TagName);
            }
            else
            {
                clsTags.SelectedTagsIDs.Remove(TagID);
                clsTags.SelectedTagsNames.Remove(TagName);
            }
        }

        private void frmChoseTags_Load(object sender, EventArgs e)
        {
            _LoadTags();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Owner.Close();
        }

        private void btnAddTag_Click(object sender, EventArgs e)
        {
            frmPopupBackGround PopupBackGround = new frmPopupBackGround(new frmAddEditTag(), true);
            PopupBackGround.PopupResult += _RefreshTags;
            PopupBackGround.Show();
        }

        private void _RefreshTags(bool PopupResult)
        {
            if (PopupResult)
            {
                TagsContainer.Controls.Clear();
                _LoadTags();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                TagsContainer.Controls.Clear();
                _LoadTags();
            }
        }

        private void tbSearch_IconLeftClick(object sender, EventArgs e)
        {
            TagsContainer.Controls.Clear();
            _LoadTags(tbSearch.Text);
        }
    }
}
