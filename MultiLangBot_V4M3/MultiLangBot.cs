using System.Threading.Tasks;
using Microsoft.Bot;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Core.Extensions;
using Microsoft.Bot.Schema;

namespace MultiLangBot_V4M3
{
    public class MultiLangBot : IBot
    {
        public async Task OnTurn(ITurnContext context)
        {
            if (context.Activity.Type is ActivityTypes.Message)
            {
                switch (context.Activity.Text)
                {
                    case "en":
                        Resources.Global.Culture = new System.Globalization.CultureInfo("en-US");
                        break;
                    case "ja":
                        Resources.Global.Culture = new System.Globalization.CultureInfo("ja-JP");
                        break;
                    case "fr":
                        Resources.Global.Culture = new System.Globalization.CultureInfo("fr-FR");
                        break;
                    case "de":
                        Resources.Global.Culture = new System.Globalization.CultureInfo("de-DE");
                        break;
                    default:
                        Resources.Global.Culture = System.Globalization.CultureInfo.CurrentCulture;
                        break;
                }

                await context.SendActivity(Resources.Global.WELCOME_MSG);
                await context.SendActivity(Resources.Global.CHANGE_LANG_MSG);

            }
        }

    }
}
