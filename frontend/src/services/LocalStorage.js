let localStorage = window.localStorage;

const LocalStorage = {

    clear() {
        localStorage.clear();
    },
    persist(key, item) {
        if (key)
            return localStorage.setItem(key, JSON.stringify(item))
        
        return localStorage.setItem(key, item);
    },
    retrieve(key) {
        return JSON.parse(localStorage.getItem(key))
    },
    remove(key) {
        localStorage.removeItem(key);
    }
};

export default LocalStorage;