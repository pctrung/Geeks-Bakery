import { Button, Modal, ModalBody, ModalFooter, ModalHeader } from "reactstrap";

export default function MyModal({
  modal,
  toggle,
  handler,
  content,
  color,
  confirm,
}) {
  return (
    <Modal className="modal-dialog-centered" isOpen={modal} toggle={toggle}>
      <ModalHeader>Are you sure?</ModalHeader>
      <ModalBody>{content}</ModalBody>
      <ModalFooter>
        <Button color={color} onClick={handler}>
          {confirm}
        </Button>
        <Button color="secondary" onClick={toggle}>
          Cancel
        </Button>
      </ModalFooter>
    </Modal>
  );
}
