namespace PetWorld.GUI.UserControls.Screens
{
    interface IRequester<T>
    {
        void Respond(T response);
    }
}
