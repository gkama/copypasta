using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Input;
using System.Windows;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace copypasta
{
	[Activity (Label = "copypasta", MainLauncher = true, Icon = "@drawable/copypaste")]
	public class MainActivity : Activity
	{
		static Random _random = new Random();

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
			namesStrings.Add ("We here at NL_KRIPP welcome all TRUMP subs. This is a safe place for you all to congregate. You will not be harmed. You are all stellar examples of humanity and we want you here. Type trumpW, let your inner donger soar.");
			namesStrings.Add ("reynad, everytime I watch you I start sweating, I believe this is because you have the power to harvest salt through my pores even through the internet, can you please stop making me sweat for more salt?");
			namesStrings.Add ("If 700,000 people die in hospitals every year. Why don't we close down these hospitals and prevent those deaths? (つ ͡° ͜ʖ ͡°)つ");
			namesStrings.Add ("Worst Matchup: Warrior ✓ Shaman ✓ Priest ✓ Rogue ✓ Druid ✓ Warlock ✓ Hunter ✓ Mage ✓ Paladin ✓");
			namesStrings.Add ("'The year is 2027. A physicist called Octavian has created the first inter-dimensional portal capable of exploring alternate galaxies. 'Finally, I have done it...' he says as he steps into the portal. He enters a room where he sees himself giving a 'Brofist' to his computer. His only reaction: '  '.'");
			namesStrings.Add ("ヽ༼ຈل͜ຈ༽ﾉ Hear, hear. All hail Kripparrian of the House TSM, the First of His Name, The One With No Life, King of Wraeclast, Prince of the Docks, Papparrian of the First Men, Emperor of the Great Sarn Sea, Breaker of DeSync, and Father of Cattarian, RIP, First and Last of His Name. ヽ༼ຈل͜ຈ༽ﾉ");
			namesStrings.Add ("Hi Imaqtpie. I noticed that in your games you utilize Kog’Maws passive A LOT, but when I watch LCS players I see them go an ENTIRE teamfight without using their passive even ONCE. Are they playing the champion to its full potential or are you?");
			namesStrings.Add ("╰( ͡° ͜ʖ ͡° )つ──☆*:・ﾟ Copypastus Totalus!! I can't believe people actually take time out of their day to copy and paste messages instead of contributing to chat. What kind of inhuman degenerate would take pleasure in wasting valuable chat space? Quite FrankerZly, it's discusseding.");
			namesStrings.Add ("High in orbit, the Gitraktmaet motherships descend upon the Earth. They prepare to enslave the world and mine it for all its salt, but the scanners detect an abnormally high concentration inside a tiny shack in Greece. The invasion won't be necessary. 'Lock onto him with the RNG disruptor,' says the captain, greedily. 'Soon we shall have all the salt we need.'");
			namesStrings.Add ("~~ ~~ ~~ DUDUDUDUDUDU ~~ ~~ ~~");
			namesStrings.Add ("<:::::[]=¤༼ຈل͜ຈ༽ﾉ My name is Maximus Kappacus Spamicus, commander of the Armies of the Twitch, General of the  Legions, loyal servant to the true Emperor Kripparrian. Father to a banned son, and husband to a banned wife. I will slay all moderinos, whether in this chat or the next. <:::::[]=¤༼ຈل͜ຈ༽ﾉ");
			namesStrings.Add ("Hello Kripp, your stream has changed my life completely. I suffer from severe NaCl (salt) deficiency disorder. I had to visit the hospital 5 times a week for salt injections. However, watching your stream supplies me enough salt through the screen. You saved me money time and effort. I can't thank you enough. I owe u my life.");
			namesStrings.Add ("Honestly, that's what Icall a cool story bro. Such a riveting tale, I honestly copy andpasted itto word, saved on my hard drive, backed it up on a jump drive, drove to the bank, put the jump drive in the safe deposit box, and will leave it there until my kids turn about 12 (when they can actually state their age, and ask what it is I'm showing them), when I will pick it up, put it in an old USB drive reader and relay this cool story to them and tell them, 'kids, this is what a cool story should look and sound like...not like the stories your generation tells'");
			namesStrings.Add ("Hey Reynad, King of Nigeria here. Through generations of inbreeding, my family tree now looks more like a family reef. The genetic defects are getting out of hand. My grandson was just born with a giant donger on his head. How will this affect my reign?");
			namesStrings.Add ("In the Realm of the Saltiverse, a young Saltkeeper named Kripparrian was chosen to free his people from their ancient enemy, the Mods. Using the magical power of Copy and Paste, Kripparrian sacrificed his salt force to banish the mods to Trump's chat. However, in doing so, Kripparian paid the ultimate sacrifice and became Casual. Please copy pasterino this talerino, so we do not forgetterino the legenderino of the Saltkeeperio Kripperino.");
			namesStrings.Add ("The Ghost of Gaming Future shows Kripp a nice house in the Toronto suburbs. Inside, Kripp, Rania and their sons are happily gaming as a family. 'This isn't so bad,' says Kripp. 'Look closer,' speaks the Ghost. Kripp looks in horror to see his sons are using tablets and playing browser cash-shop games. 'This is your future Casualarrian.'");
			namesStrings.Add ("୧༼ಠ益▀ ༽୨ “This scallywag's deck be kookoo bananas!” ☑ “Me deck can nae scourge tis deck!” ☑ “This swab needed precisely them cards to send me deck to Davey Jones’ locker.” ☑ “He top-pillaged th' only card on the high seas that could best me.” ☑ “Thar was naught I could do.” ☑ “I weathered that perfectly” ☑ ୧༼ಠ益▀ ༽୨");
			namesStrings.Add ("Born too late to explore the Earth, born too early to explore the universe, born perfectly to explore dank memes ◕ ͜ ʖ ͡ ͡◕");
			namesStrings.Add ("໒( •̀ ╭ ͟ʖ╮ •́ )७ It is me Kripp Jong Un. I demand that all showings of 'Topdecking and Wrecking 3: Gripped and Kripped' be removed immediately. Those who refuse will be pepperonied ໒( •̀ ╭ ͟ʖ╮ •́ )७");
			namesStrings.Add ("ヽ༼◕ل͜◕༽ﾉ Who let the dongs out?! Woof ╰( ͡°ᴥ ͡° ʋ)╯ Woof woof woof woof ╰( ͡°ᴥ ͡° ");
			namesStrings.Add ("'▬▬ι═══════ﺤ As I ʜᴏʟᴅ ᴛʜᴇ sᴀᴍᴜʀᴀɪ sᴡᴏʀᴅ ᴛᴏ ᴍʏ sᴛᴏᴍᴀᴄʜ ᴀs I ᴡᴀs ᴀʙᴏᴜᴛ ᴛᴏ ᴄᴏᴍᴍɪᴛ sᴜᴅᴏᴋᴜ, I ᴡᴀᴛᴄʜ Kʀɪᴘᴘ ᴘʟᴀʏ Cᴀsᴜᴀʟsᴛᴏɴᴇ... I ʀᴇᴍᴇᴍʙᴇʀ ᴀ ᴛɪᴍᴇ ᴡʜᴇʀᴇ Kʀɪᴘ ᴡᴀs Nᴏʟɪғᴇ... ɴᴏᴡ I ᴀᴍ Nᴏʟɪғᴇ...ɢᴏᴏᴅ ʙʏᴇ ᴋʀɪᴘᴘ -═══════ι▬▬'");
			namesStrings.Add ("Hey mods I just wanted to congratulate you all and give proper respect for keeping our chats safe from the evils of Twitch, the spammers, and sexual predators. Without you and your methods, which have no affiliation to the leading German political party within the time frame of World War 2, we would not be able to enjoy a fun, clean environment in which we can enrich ourselves with game knowledge and truly become one as a great family for the greater good of internet chatrooms. Again, I would like to say you have done a wonderful job and hope to see you all keep up the great work.");
			namesStrings.Add ("When jon lenon was 10 his teacher askd 'what do u wana do when u are adult?' and jon lenon said 'hapy'. the teacher said 'u didn't understand question' and lenon said 'u dont understand life.'. The teacher was alber Einstein, retweet if u beliv in god");
			namesStrings.Add ("Hello, my name is Boris Ilya Pistolento. I'm from a small village in cold Siberia. For many years I dreamed of a profession, Cardstone player! But tetris all I can do. One day a trucker was crash in the back of the house of mine and a box fell out. It was the commodore 64, my dreaming is comming to reality. Now I can join the local tournamento, the prize pool of which 4 potatoes. Please no Copy-Pasta!");
			namesStrings.Add ("( ° ͜ʖ͡°)╭∩╮ Hey Blizzard, here's an 'extended maintenance' for you ( ° ͜ʖ͡°)╭∩╮");
			namesStrings.Add ("Hello, i come to seek help. I am interested in trying to discover a way to produce eggs much like a chicken does. i have tested inserting the egg into myself and hoping it will act like a seed and grow like a tree in my belly but so far it has not been successful. Please help i struggle to sleep at night without an answer.");
			namesStrings.Add ("(◞≼◉ื≽◟ ;益;◞≼◉ื≽◟) ╭∩∩∩∩∩╮ HEY CHAT HERE'S A HIGH FIVE FOR YOU (◞≼◉ื≽◟ ;益;◞≼◉ื≽◟) ╭∩∩∩∩∩╮");
			namesStrings.Add ("༼ ಠل͟ಠ༽︻デ=一 DIE SPIDER /ก็็็็็็็็็็็็็╭(▀̿Ĺ̯▀̿ ̿)╮ก็็็็็็็็็็็็็");
			namesStrings.Add ("ʷʰᵉᶰ ˢᵖᵃᵐ, ᵐʸ ᵗᵉˣᵗ ᵃᵘᵗᵒᵐᵃᵗᶦᶜᵃᶫᶫʸ ᵍᵒ ᵗᵒ ᵗʰᵉ ˢᵐᵃᶫᶫᵉˢᵗ ˢᶦᶻᵉ⋅ ᶦ ᶜᵃᶰ ᵐᵃˣᶦᵐᶦᶻᵉ ˢᵖᵃᵐ ᵖᵉʳ ᵖᶦˣᵉᶫ ᵃᶰᵈ ᶦᶰᶜʳᵉᵃˢᵉ ᵗʰᵉ ᵈᶦᶠᶠᶦᶜᵘᶫᵗʸ ᵗᵒ ʳᵉᵃᵈ ˢᵃᶦᵈ ˢᵖᵃᵐ ᶜᵃᵘˢᶦᶰᵍ ᶠʳᵘˢᵗʳᵃᵗᶦᵒᶰ ᵒᶠ ᵗʰᵉ ᵛᶦᵉʷᵉʳ⋅ ᵃᶫᶫ ᵇᵉᶜᵒᵐᶦᶰᵍ ᵐᵃˣᶦᵐᵘᵐ ᵉᶠᶠᶦᶜᶦᵉᶰᶜʸ");
			namesStrings.Add ("Hello, I'm Sarah McLanchdong. Every day millions of poor, helpless dongers go unraised everyday. Dongers that are abused and negated, like this poor fellow ༼ ▀̿ ̿ ل͟ຈ ༽. For just one Dongerbill [̲$̲(̲ ͡° ͜ʖ ͡°̲)̲$̲] a day we can help save these forgotten dongers (◉_☢) ༼ ͝°ʖಠ ༽ ( ͡°ل͜ º) from a life time of being lowered. Your there only hope, because just a minute of your time and a single Dongerbill [̲$̲(̲ ͡° ͜ʖ ͡°̲)̲$̲] can save a life.");
			namesStrings.Add ("They say 9 out of 10 twitch users are dumb. I'm so glad to be in the other 1 percent");
			namesStrings.Add ("Hey guys i lost one of my dogs :( Could you help me to find him? Please Type (Franker Z) Or  (Ralpher Z) To find them! Thank you! The Twitch Chat is so intellectula!  No Copypasterino Wufferino please!!!!!");
			namesStrings.Add ("In the beginning Reynad created the Hearth and the Stone. There were no cards nor a meta. Then Reynad said 'Let there be cards'; and there were cards. He then said 'Let there be a Meta'; and there was a Meta. ~ The Book of Dennisis");
			namesStrings.Add ("|̅|(̅|̅◉̅|̅◡̅|̅◔̅|̅)̅| HELP I'M STUCK IN KRIPP'S BASEMENT |̅|(̅|̅◉̅|̅◡̅|̅◔̅|̅)̅|");
			namesStrings.Add ("If you’re reading this, you’ve been in coma for almost 20 years now. We’re trying a new technique. We don’t know where this message will end up in your dream, but we hope it works. Please wake up, we miss you.");
			namesStrings.Add ("When Kripp gets topdecked, it's seen as a bit of salty fun. BUT when Reynad gets a 420 YOLO Rag Pro 5000 hit to the face with 6 different minions on the board, lethal next turn, together with top-deck skill command with one mana webspinner, he's called Salt God?");
			namesStrings.Add ("Hello Kripp, This is Vegetron Ruler and Protector of all plant matter in the galaxy. I command you to stop being a p*ssy and eat meat, instead of eating all of my relatives. If you don't, I will be super angry at you. You've been warned.");
			namesStrings.Add ("HELLO CHAT. My NAME Sergei Copypastavich from Russia. You all steal my family name and violate copyright law 459.53 of Ruski Constituski. I sue all of you and me and Putin laugh and play in pile of twitch monies. As they say in amarica F*CK To YOU, Pay to me!!");
			namesStrings.Add ("The year is 1945. 'Hafu,' Trump speaks breathlessly into the night. 'Get back to the time machine. We have what we need here.' A foul smirk plays upon his lips as he pockets a top-secret Nazi folder marked 'Sub Mode.' Lightning flashes and thunder crashes far across the German mountains. 'We will see who says Tuck Frump' now,' he says.");
			namesStrings.Add ("ー═┻┳︻▄ξ(╬ಠ益ಠ)ξ▄︻┻┳═一 'YOU'LL NEVER TAKE ME ALIVE MODS!'");
			namesStrings.Add ("Wait a minute. I just spotted an inconsistency. Could this be the work of the CIA? Look closely... below the stream. '10,000 viewers'. What the heck? There's only 7 million people in the world, how could there possibly be 10 million viewers right now?");
			namesStrings.Add ("☭☭☭☭☭☭☭☭☭☭☭☭☭ SORRY I DROPPED MY BAG OF COMMUNISTS ☭☭☭☭☭☭☭☭☭☭☭☭☭");
			namesStrings.Add ("Dear reynard. I was hiking in the Amazon Rainforest the other day when I was bit by a snake. Miles from the nearest city, I thought my life was over as the venom slowly spread across my body. But then I used my 4G to open twitch and the salt from your stream sucked the venom out of my wound and saved my life. Thanks Reynad!");
			namesStrings.Add("The year is 2129; humans can only communicate through increasingly garbled copy-pasta. A man approaches and says 'ire: ███ 10 ｓｔｒｏｋｅ ｄｉｃｋ ff ☑ EKT ☾ ☆ ¸. ?' In confusion, I reply 'AT ASCII ຈل͜ل͜ຈຈ༽༽ﾉﾉ HA ʙᴏʟᴀ ヽ༼ಢ_ ♌ ❛ั∗)◞ TUCK F (◡‿◡✿)'. This is the world we have wrought.");
			namesStrings.Add ("Hi, my name is Bill Gates and today I’ll teach you how to count to ten: 1, 2, 3, 95, 98, NT, 2000, XP, Vista, 7, 8, 10");
			namesStrings.Add ("(° ~͜ʖ~ °)I heard-a you-a guys-a like-a da pasta!(° ~͜ʖ~ °)");
			namesStrings.Add ("Sodium, atomic number 11, was first isolated by Humphry Davy in 1807. A chemical component of salt, he named it Na in honor of the saltiest region on earth, North America.");
			namesStrings.Add ("Hello, I am currently 15 years old and I want to become a walrus. I know there's a million people out there just like me, but I promise you I'm different. On December 14th, I'm moving to Antarctica; home of the greatest walri. I've already cut off my arms, and now slide on my stomach everywhere I go as training. I may not be a walrus yet, but I promise you if you give me a chance and the support I need, I will become the greatest walrus ever. Thank you all.");
			namesStrings.Add ("☐ sᴀʟᴛ ☐ ᴠᴇʀʏ sᴀʟᴛ ☐ ᴘᴊsᴀʟᴛ ☐ ᴇxᴛʀᴇᴍᴇ sᴏᴅɪᴜᴍ sᴀʟᴛsᴛᴏʀᴍ 9000 ☑ ʀᴇʏɴᴀᴅ");
			namesStrings.Add ("ᴛᴏ ᴘʀᴏᴛᴇᴄᴛ ᴛʜᴇ ᴄʜᴀᴛ ғʀᴏᴍ ᴅᴇᴠᴀsᴛᴀᴛɪᴏɴ. ᴛᴏ ᴜɴɪᴛᴇ ᴀʟʟ sᴘᴀᴍᴍᴇʀs ᴡɪᴛʜɪɴ ᴏᴜʀ ɴᴀᴛɪᴏɴ. ᴛᴏ ᴅᴇɴᴏᴜɴᴄᴇ ᴛʜᴇ ᴇᴠɪʟ ᴏғ Tʀᴜᴍᴘ ᴀɴᴅ ᴍᴏᴅs. ᴛᴏ ᴇxᴛᴇɴᴅ ᴏᴜʀ sᴘᴀᴍ ᴛᴏ ᴛʜᴇ sᴛᴀʀs ᴀʙᴏᴠᴇ. ᴄᴏᴘʏ! ᴘᴀsᴛᴇ! ᴄʜᴀᴛ sᴘᴀᴍ ʙʟᴀsᴛ ᴏғғ ᴀᴛ ᴛʜᴇ sᴘᴇᴇᴅ ᴏғ ʟɪɢʜᴛ! sᴜʀʀᴇɴᴅᴇʀ ᴍᴏᴅs ᴏʀ ᴘʀᴇᴘᴀʀᴇ ᴛᴏ ғɪɢʜᴛ! Kʀɪᴘᴘ, ᴛʜᴀᴛs ʀɪɢʜᴛ!");
			namesStrings.Add ("☐ Not REKT ☑ REKT ☑ REKTangle ☑ SHREKT ☑ REKT-it Ralph ☑ Total REKTall ☑ The Lord of the REKT ☑ The Usual SusREKTs ☑ North by NorthREKT ☑ REKT to the Future ☑ Once Upon a Time in the REKT ☑ The Good, the Bad, and the REKT ☑ LawREKT of Arabia ☑ Tyrannosaurus REKT ☑ eREKTile dysfunction ");
			namesStrings.Add ("The stream starts, and so my spam begins. It shall not end until i am banned. I shall fear no mod, sub to no streamer. I shall live and die in the Chat. For i am the value in the bomber. I am the BM in the lethal. I am the salt in the defeat. I pledge my keyboard to the Chat, for this stream and all the streams to come.");
			namesStrings.Add ("( ͡° ͜ʖ ͡°) Every 60 seconds in Africa, a minute passes. Together we can stop this. Please spread the word ( ͡° ͜ʖ ͡°)");
			namesStrings.Add ("ᶦ ˢʷᵉᵃʳ ᵗᵒ ᵍᵒᵈ ᶦᶠ ᵃᶰʸ ᵒᶠ ʸᵒᵘ ᵐᵒᵗʰᵉʳʳᶠᵘᶜᵏᵉʳˢ ᶜᵒᵖʸ ᵃᶰᵈ ᵖᵃˢᵗᵉ ᵗʰᶦˢ ʸᵒᵘ ʷᶦᶫᶫ ᵇᵉ ᶦᶰ ˢᵉʳᶦᵒᵘˢ ᵗʳᵒᵘᵇᶫᵉ");
			namesStrings.Add ("This is Gambit ༼ ºل͟º༼ ºل͟º( ͡° ͡ ͜ ͡ʖ ͡ °)ºل͟º ༽ºل͟º ༽ 5 MEN 9 EYEBROWS , 1 DREAM");
			namesStrings.Add("Europe was founded in 1848 by Walker Texas Ranger when he rode a horse across the Atlantic, he called it 'Eastern USA' which was eventually abbreviated as just 'EU'");
			namesStrings.Add("The teacher asked Kripp, 'Why is your cat at school today Kripp?' Kripp replied crying, 'Because I heard my daddy tell my mommy, 'I am going to eat that p*ssy once Kripp leaves for school today!'");
			namesStrings.Add ("ＫＲＩＰＰ ＴＨＩＳ ＩＳ ＨＡＦＵ． ＹＯＵ ＡＲＥ ＩＮ ＴＲＯＵＢＬＥ ＭＩＳＴＥＲ． Ｙｏｕ ａｒｅ ｎｏｔ ｇａｙ！ Ｙｏｕ ｔａｌｋ ｔｏ ｍｅ ｏｎ ｔｈｅ ｐｈｏｎｅ ｅｖｅｒｙ ｎｉｇｈｔ， ａｎｄ ｗｈｏ ｃａｎ ｆｏｒｇｅｔ ｏｕｒ ｎｉｇｈｔｓ ｏｆ ｅｎｄｌｅｓｓ ｎｉｐｐｌｅ ｐｌａｙ？ Ｓｔｏｐ ｔｈｅ ｃｈａｒａｄｅ ａｎｄ ｃｏｍｅ ｂａｃｋ ｔｏ ｙｏｕｒ Ｈａｆｕ ｂａｂｙ． Ｐｌｚ ｎｏ ｃｏｐｙ ｐａｓｔｅｒｉｎｏ ｃｈｉｎｇ ｃｈｏｎｇ ｃｈａｎｇｅｒｉｎｏ ｎｏｏｄｌｅｒｉｎｏ ｂｏｋ ｃｈｏｙ ｋｕｎｇ ｐａｏｒｉｎｏ．");
			namesStrings.Add ("If 700,000 people die in hospitals every year. Why don't we close down these hospitals and prevent those deaths? (つ ͡° ͜ʖ ͡°)つ");



			String[] neamsStringsArray = namesStrings.ToArray ();
			Shuffle (neamsStringsArray);

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
				newTextView.Text = neamsStringsArray [i];
				newTextView.SetPadding(10, 10, 10, 10);

				newLinearLayout.AddView (newTextView);
				copypastaMainview.AddView (newLinearLayout);

				newTextView.Click += delegate {
					var clipboard = (ClipboardManager)GetSystemService(ClipboardService);
					var clip = ClipData.NewPlainText("text", newTextView.Text.ToString());

					clipboard.PrimaryClip = clip;

					newLinearLayout.SetBackgroundColor(Android.Graphics.Color.ParseColor("#82000000"));

					Toast.MakeText (this, "Copied", ToastLength.Long).Show();
				};
			}
		}

		// Shuffle
		static void Shuffle<String>(String[] array)
		{
			int n = array.Length;
			for (int i = 0; i < n; i++)
			{
				// NextDouble returns a random number between 0 and 1.
				// ... It is equivalent to Math.random() in Java.
				int r = i + (int)(_random.NextDouble() * (n - i));
				String t = array[r];
				array[r] = array[i];
				array[i] = t;
			}
		}
	}
}


