using System;

namespace App05_AuthState.Services
{
    public class AuthenticationStateService
    {
        // Property to hold the current login status
        public bool IsAuthenticated { get; private set; } = false;

        // Event to notify components when the state changes
        public event Action? OnStateChanged;

        // Method to Log In
        public void LogIn()
        {
            if (!IsAuthenticated)
            {
                IsAuthenticated = true;
                NotifyStateChanged();
            }
        }

        // Method to Log Out
        public void LogOut()
        {
            if (IsAuthenticated)
            {
                IsAuthenticated = false;
                NotifyStateChanged();
            }
        }

        // Helper method to trigger the event
        private void NotifyStateChanged() => OnStateChanged?.Invoke();
    }
}