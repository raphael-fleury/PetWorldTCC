import LocalStorage from './LocalStorage';

const AuthService = {

    getToken() {
        return LocalStorage.retrieve('token');
    },
    setToken(token: String) {
        LocalStorage.persist('token', token);
    },
    clear() {
        LocalStorage.clear();
    }
};

export default AuthService;

