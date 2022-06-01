import React from "react";
import Message from "./Message";

const ChatWindow = (props) => {
  const chat = props.chat.map((m) => (
    <Message key={m.user} user={m.user} message={m.message} />
  ));
  return <div>{chat}</div>;
};

export default ChatWindow;
