using System;

namespace SevenAndAHalf.Services
{
    // languages
    public enum Language
    {
        IT,
        EN
    }

    public static class Lang
    {
        // set deafault language to Language.IT
        private static Language currentLanguage = Language.IT;
        public static void SetLanguage(Language lang)
        {
            currentLanguage = lang;
        }

        /// <summary>
        /// Returns a localized string (IT / EN) associated with a key.
        /// The string may contain placeholders {0}, {1}, etc. which are
        /// replaced using string.Format with the provided arguments.
        /// </summary>
        /// <param name="key">
        /// Identifier of the text (e.g. "pc_drew", "player_bust").
        /// </param>
        /// <param name="args">
        /// Optional values used to replace placeholders in the string.
        /// </param>
        /// <returns>
        /// Translated and formatted text based on the current language.
        /// </returns>
        public static string Translation(string key, params object[] args)
        {
            string text;

            switch (key)
            {
                case "start_new_game":
                    text = currentLanguage == Language.IT ? "Iniziata una nuova partita." : "Started a new game.";
                    break;
                case "show_rules":
                    text = currentLanguage == Language.IT ? "Leggere le regole prima di iniziare? Si[s] No[n]" : "Read rules before starting? Yes[y] No[n]";
                    break;
                case "start_round":
                    text = currentLanguage == Language.IT ? "Iniziare partita? Si[s] No[n]" : "Start game? Yes[y] No[n]";
                    break;
                case "start_new_round":
                    text = currentLanguage == Language.IT ? "Iniziare un'altra partita? Si[s] No[n]" : "Start another game? Yes[y] No[n]";
                    break;
                case "no_cards":
                    text = currentLanguage == Language.IT ? "Non ci sono carte rimaste." : "No cards left.";
                    break;
                case "pc_drew":
                    text = currentLanguage == Language.IT ? "PC ha pescato {0}, con valore {1}, totale ora {2}" : "PC drew {0}, with value {1}, total now {2}";
                    break;
                case "human_drew":
                    text = currentLanguage == Language.IT ? "Hai pescato {0}, con valore {1}, totale ora {2}" : "You drew {0}, with value {1}, total now {2}";
                    break;
                case "first_turn_query":
                    text = currentLanguage == Language.IT ? "Inizi con la carta: {0} Totale punti: {1} \n Scegli: Carta[c] Stare[s]" : "You start with: {0} Total points: {1} \n Choose: Card[c] Stay[s]";
                    break;
                case "subsequent_turn_query":
                    text = currentLanguage == Language.IT ? "Carta pescata: {0} Totale punti: {1} \n Scegli: Carta[c] Stare[s]" : "Drawn card: {0} Total points: {1} \n Choose: Card[c] Stay[s]";
                    break;
                case "draw_matta":
                    text = currentLanguage == Language.IT ? "Hai pescato una matta! Se hai altre carte, il suo valore sarà tale da garantire che il totale sia 7.5." : "You drew a jolly! If you have other cards, its value will be adjusted so that your total points equal 7.5.";
                    break;
                case "player_bust":
                    text = currentLanguage == Language.IT ? "Carta pescata: {0} Totale punti: {1} Hai sballato! Vince il PC (mazziere)." : "Drawed card: {0} Total points: {1} You went bust! The PC wins (dealer).";
                    break;
                case "player_bust_short":
                    text = currentLanguage == Language.IT ? "Hai sballato!" : "You went bust!";
                    break;
                case "pc_bust":
                    text = currentLanguage == Language.IT ? "Il PC ha sballato! Hai vinto!" : "The PC went bust! You win!";
                    break;
                case "pc_stay":
                    text = currentLanguage == Language.IT ? "Il PC ha deciso di stare!" : "The PC decided to stay";
                    break;
                case "player_wins":
                    text = currentLanguage == Language.IT ? "Hai vinto!" : "You win!";
                    break;
                case "pc_wins":
                    text = currentLanguage == Language.IT ? "Ha vinto il PC!" : "The PC wins!";
                    break;
                case "tie_dealer_wins":
                    text = currentLanguage == Language.IT ? "Entrambi hanno 7.5, ma il mazziere vince! Ha vinto il PC!" : "Both have 7.5, but the dealer wins! The PC wins!";
                    break;
                case "draw_game":
                    text = currentLanguage == Language.IT ? "Pareggio! Entrambi hanno {0} punti." : "Draw! Both you and the PC have {0} points.";
                    break;
                case "invalid_input":
                    text = currentLanguage == Language.IT ? "Input non valido, riprova." : "Invalid input, try again.";
                    break;
                case "ask_input_ok_no":
                    text = currentLanguage == Language.IT ? "Inserisci '{0}' o '{1}' per sì o '{2}' per no." : "Enter '{0}' or '{1}' for yes or '{2}' for no.";
                    break;
                case "rules_header":
                    text = currentLanguage == Language.IT ? "Regole del gioco 7 e mezzo:" : "Rules of 7 and a half game:";
                    break;
                case "rules_0":
                    text = currentLanguage == Language.IT ? "Giocherai con un due mazzi mischiati assieme per un totale di 80 carte (1, 2, 3, 4, 5, 6, 7, F, C, R, M)" : "You will play with two decks mixed together for a total of 80 cards (1, 2, 3, 4, 5, 6, 7, J, Q, K, J)";
                    break;
                case "rules_1":
                    text = currentLanguage == Language.IT ? "1. Lo scopo del gioco è avvicinarsi il più possibile a 7.5 punti senza superarlo." : "1. The goal is to get as close as possible to 7.5 without going over.";
                    break;
                case "rules_2":
                    text = currentLanguage == Language.IT ? "2. Le carte numerate da 1 a 7 valgono il loro valore nominale in punti." : "2. Cards 1 to 7 are worth their face value.";
                    break;
                case "rules_3":
                    text = currentLanguage == Language.IT ? "3. Le figure (Fante, Cavallo, Re) valgono 0.5 punti ciascuna." : "3. Face cards (Jack, Knight, King) are worth 0.5 points.";
                    break;
                case "rules_4":
                    text = currentLanguage == Language.IT ? "4. La Matta può valere 0.5 punti o il valore necessario per raggiungere esattamente 7.5 punti, se si hanno altre carte in mano." : "4. The wild card can be worth 0.5 or exactly enough to reach 7.5 if you have other cards.";
                    break;
                case "rules_5":
                    text = currentLanguage == Language.IT ? "5. I giocatori possono scegliere di pescare un'altra carta o stare." : "5. Players can choose to draw or stay.";
                    break;
                case "rules_6":
                    text = currentLanguage == Language.IT ? "6. Se un giocatore supera i 7.5 punti, perde automaticamente la partita." : "6. If a player goes over 7.5, they lose automatically.";
                    break;
                case "rules_7":
                    text = currentLanguage == Language.IT ? "7. Se il giocatore decide di stare, allora inizia il turno del computer." : "7. If the player stays, the computer’s turn begins.";
                    break;
                case "rules_8":
                    text = currentLanguage == Language.IT ? "8. Se il giocatore o il computer raggiungono esattamente 7.5 punti, vincono automaticamente la partita." : "8. If player or PC reach exactly 7.5, they automatically win.";
                    break;
                case "rules_9":
                    text = currentLanguage == Language.IT ? "9. Se entrambi hanno 7.5 punti, vince il computer perchè si tratta del mazziere." : "9. If both have 7.5, the computer wins because it is the dealer.";
                    break;
                case "rules_end":
                    text = currentLanguage == Language.IT ? "Buona fortuna e buon divertimento!" : "Good luck and have fun!";
                    break;
                case "exit":
                    text = currentLanguage == Language.IT ? "Uscita dal programma..." : "Exiting program...";
                    break;
                case "invalid_card":
                    text = currentLanguage == Language.IT ? "Carta non valida" : "Invalid card";
                    break;
                case "not_supposed":
                    text = currentLanguage == Language.IT ? "Questo non dovrebbe succedere" : "This is not supposed to happen";
                    break;
                default:
                    text = "[TESTO MANCANTE]";
                    break;
            }
            return string.Format(text, args);
        }
    }
}