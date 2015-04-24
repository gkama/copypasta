using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Input;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace copypasta
{
	[Activity (Label = "copypasta", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			//ScrollView scrollView = new ScrollView (this);


			//scrollView.AddView (copypastaMainview);
			SetContentView (Resource.Layout.Main);

			List<String> namesStrings = new List<String> ();

			LinearLayout copypastaMainview = FindViewById<LinearLayout> (Resource.Id.copypastaMainview1);

			TextView copypastaText1 = FindViewById<TextView> (Resource.Id.copypastaText1);

			// Strings
			namesStrings.Add ("ᴋʀɪᴘᴘ, ᴛʜɪs ɪs ᴛʜᴇ ᴍᴀʏᴏʀ ᴏғ ᴄᴀɴᴀᴅᴀʟᴀɴᴅ. ᴡᴇ ɴᴇᴇᴅ ʏᴏᴜ ʜᴏᴍᴇ ᴍʏ sᴏɴ, ᴇᴠᴇʀ sɪɴᴄᴇ ʏᴏᴜ ʟᴇғᴛ ᴜs ᴏᴜʀ sᴀʟᴛ ᴍɪɴᴇs ʜᴀᴠᴇ ʙᴇᴇɴ ʀᴜɴɴɪɴɢ ᴅʀʏ. ɴᴏ ᴏɴᴇ ɪs ᴘʀᴏᴠɪᴅɪɴɢ ᴛʜᴇsᴇ ᴘᴏᴏʀ ʜᴀʀᴅ-ᴡᴏʀᴋɪɴɢ ᴘᴇᴏᴘʟᴇ ᴡɪᴛʜ ᴛʜᴇ ᴛᴀʙʟᴇ sᴀʟᴛ ᴛʜᴇʏ ᴅᴇsᴇʀᴠᴇ ғᴏʀ ᴛʜᴇɪʀ ᴅᴀɪʟʏ ᴍᴇᴀʟs. ᴡᴇ ɴᴇᴇᴅ ʏᴏᴜ ᴏᴄᴛᴀᴠɪᴀɴ.");
			namesStrings.Add ("Hey Reynad! Nice to see you streaming again. I see you've decided you want to look like a pencil. Good for you man, follow your dreams. You'll be erasing your foes in no time.");
			namesStrings.Add ("Hi Trump I was banned for posting 'long paragraphs' according to my 3rd grade english teacher a paragraph is 6 or more sentences and a long paragraph is over 9. I would like compensation for this bannerino i recieved from some of your le nazi mods. I think that this should recieve at least 420/69 points for my paper. Please no copy pasterilni linguini pleaserini.");
			namesStrings.Add ("Kripp, Blizzard here again. We've noticed that you've been away from Hearthstone for at least 2 hours. We're just wondering if everything is okay. Is it still mages? We're serious about nerfing them if it's a problem to you. Our Viewbots are ready to bring you much ad revenue. Thank you Kripp, hope to see you soon!");
			namesStrings.Add ("( ರ Ĺ̯ ರೃ ) Hello Kripparian. Reginald and Dan Dinh, Owners of Team SoloMid™ here. We gained access to your Hearthstone account and couldn't help but notice the absence of the 'legendary' card back. This poorly reflects on Team SoloMid, and, as such, we have decided to remove you from the team. Please return your jacket. Thank you ( ರ Ĺ̯ ರೃ )");
			namesStrings.Add("We here at NL_KRIPP welcome all TRUMP subs. This is a safe place for you all to congregate. You will not be harmed. You are all stellar examples of humanity and we want you here. Type trumpW, let your inner donger soar.");

			//Color color = System.Drawing.ColorTranslator.FromHtml("#b4000000");

			for (int i = 0; i < namesStrings.Count; i++) {
				// LinearLayout
				LinearLayout newLinearLayout = new LinearLayout (this);
				// customize layout
				LinearLayout.LayoutParams linearLayoutParams = new LinearLayout.LayoutParams(LinearLayout.LayoutParams.WrapContent,
					LinearLayout.LayoutParams.WrapContent);
				linearLayoutParams.SetMargins (0, 0, 0, 15);
				newLinearLayout.Orientation = Orientation.Horizontal;
				newLinearLayout.SetGravity (GravityFlags.Center);
				newLinearLayout.SetBackgroundColor(Android.Graphics.Color.ParseColor("#b4000000"));
				newLinearLayout.LayoutParameters = linearLayoutParams;

				// TextView
				TextView newTextView = new TextView (this);
				// customize text view
				newTextView.SetTextAppearance(this, 1);
				newTextView.Text = namesStrings [i];
				newTextView.SetPadding(6, 6, 6, 6);

				newLinearLayout.AddView (newTextView);
				copypastaMainview.AddView (newLinearLayout);
			}

		}
	}
}


