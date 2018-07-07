import reducer from "../../futils/reducer";

const NotificatonActionHandlers = {
  SHOWTOAST: (s, a) => ({ ...s, toasted: true, content: a.payload.content }),
  HIDETOAST: s => ({ ...s, toasted: false })
};

const NotifierInit = { toasted: false, content: "", danger: false };

export default reducer(NotifierInit, NotificatonActionHandlers);
