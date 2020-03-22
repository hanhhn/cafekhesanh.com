import { SignedInFail, SignedInSuccess, SignOut } from "../actions/action.type";

const authReducer = (
  state = {
    isLogged: false,
    accessToken: null,
    email: null
  },
  action: any
) => {
  switch (action.type) {
    case SignedInSuccess:
      return {
        ...state,
        isLogged: action.isLogged,
        accessToken: action.accessToken,
        email: action.email
      };

    case SignedInFail:
      return {
        ...state,
        isLogged: false
      };

    case SignOut:
      return {
        ...state,
        isLogged: false
      };

    default:
      return state;
  }
};

export default authReducer;
