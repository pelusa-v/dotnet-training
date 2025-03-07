using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Dialogs;

namespace EchoBot;

public class UserProfileDialog : ComponentDialog
{
    public UserProfileDialog()
        : base(nameof(UserProfileDialog))
    {
        // Define los pasos del Waterfall Dialog
        var waterfallSteps = new WaterfallStep[]
        {
            AskForNameAsync,
            AskForAgeAsync,
            ShowSummaryAsync
        };

        // Agrega el Waterfall Dialog al conjunto de diálogos
        AddDialog(new WaterfallDialog(nameof(WaterfallDialog), waterfallSteps));
        AddDialog(new TextPrompt(nameof(TextPrompt)));
        AddDialog(new NumberPrompt<int>(nameof(NumberPrompt<int>)));
    }

    private async Task<DialogTurnResult> AskForNameAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
    {
        // Pregunta el nombre del usuario
        return await stepContext.PromptAsync(
            nameof(TextPrompt),
            new PromptOptions { Prompt = MessageFactory.Text("Por favor, dime tu nombre.") },
            cancellationToken);
    }

    private async Task<DialogTurnResult> AskForAgeAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
    {
        // Guarda el nombre del usuario en el estado del diálogo
        stepContext.Values["name"] = (string)stepContext.Result;

        // Pregunta la edad del usuario
        return await stepContext.PromptAsync(
            nameof(NumberPrompt<int>),
            new PromptOptions { Prompt = MessageFactory.Text("¿Cuántos años tienes?") },
            cancellationToken);
    }

    private async Task<DialogTurnResult> ShowSummaryAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
    {
        // Guarda la edad del usuario en el estado del diálogo
        stepContext.Values["age"] = (int)stepContext.Result;

        // Obtiene los valores guardados
        var name = (string)stepContext.Values["name"];
        var age = (int)stepContext.Values["age"];

        // Muestra un resumen al usuario
        await stepContext.Context.SendActivityAsync(MessageFactory.Text($"Gracias, {name}. Tienes {age} años."), cancellationToken);

        // Finaliza el diálogo
        return await stepContext.EndDialogAsync(cancellationToken: cancellationToken);
    }
}